using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using zlib;

namespace CharacterEditor
{
	public class Database
	{
		private SQLiteConnection connection;

		public void Load(string filename)
		{
			string connectionString = String.Format("Data Source={0};Version=3", filename);
			connection = new SQLiteConnection(connectionString);
			connection.Open();
		}

		public byte[] ReadCharacterBlob(int index)
		{
			byte[] stream = ReadBlobByIndex(index);
			byte[] decompressedStream;

			DecompressData(stream, out decompressedStream);

			return decompressedStream;
		}

		public bool WriteCharacterBlob(int index, byte[] data)
		{
			byte[] compressedStream;
			CompressData(data, out compressedStream);

			return WriteBlobByIndex(index, compressedStream);
		}

		public bool WriteBlobByIndex(int index, byte[] data)
		{
			using (SQLiteCommand command = new SQLiteCommand(connection))
			{
				command.CommandText = String.Format("UPDATE `blobs` SET `value`=@blobData WHERE `key`='{0}'", index);
				command.Parameters.Add(new SQLiteParameter("@blobData", DbType.Binary)
				{
					Value = data
				});

				return command.ExecuteNonQuery() == 1;
			}
		}

		public byte[] ReadBlobByIndex(int index)
		{
			return ReadBlobByKey(index.ToString("G"));
		}

		public byte[] ReadBlobByKey(string index)
		{
			DataTable table = new DataTable();

			using (SQLiteCommand command = new SQLiteCommand(connection))
			{
				command.CommandText = String.Format("SELECT `value` FROM `blobs` WHERE `key`='{0}'", index);
				SQLiteDataReader reader = command.ExecuteReader();
				table.Load(reader);
				reader.Close();
			}

			if (table.Rows.Count == 0)
				return null;

			return (byte[])table.Rows[0].ItemArray.First();
		}

		private static void CompressData(byte[] inData, out byte[] outData)
		{
			using (MemoryStream outMemoryStream = new MemoryStream())
			{
				using (ZOutputStream outZStream = new ZOutputStream(outMemoryStream, zlibConst.Z_DEFAULT_COMPRESSION))
				{
					using (Stream inMemoryStream = new MemoryStream(inData))
					{
						CopyStream(inMemoryStream, outZStream);
						outZStream.finish();

						outData = outMemoryStream.ToArray();
					}
				}
			}
		}

		private static void DecompressData(byte[] inData, out byte[] outData)
		{
			using (MemoryStream outMemoryStream = new MemoryStream())
			{
				using (ZOutputStream outZStream = new ZOutputStream(outMemoryStream))
				{
					using (Stream inMemoryStream = new MemoryStream(inData))
					{
						CopyStream(inMemoryStream, outZStream);
						outZStream.finish();

						outData = outMemoryStream.ToArray();
					}
				}
			}
		}

		private static void CopyStream(Stream input, Stream output)
		{
			const int bufferLength = 2048;

			byte[] buffer = new byte[bufferLength];
			int len;

			while ((len = input.Read(buffer, 0, bufferLength)) > 0)
				output.Write(buffer, 0, len);

			output.Flush();
		}
	}
}
