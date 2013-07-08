using System;
using System.IO;
using System.Text;

namespace CharacterEditor
{
	static class Utility
	{
		public static string ReadLongString(this BinaryReader reader)
		{
			int length = reader.ReadInt32();
			byte[] value = new byte[length];

			reader.Read(value, 0, length);

			return Encoding.ASCII.GetString(value);
		}

		public static int ReadIntAtOffset(this BinaryReader reader, long position)
		{
			long previousPosition = reader.BaseStream.Position;
			reader.BaseStream.Position = position;

			int value = reader.ReadInt32();

			reader.BaseStream.Position = previousPosition;

			return value;
		}

		public static float ReadSingleAtOffset(this BinaryReader reader, long position)
		{
			long previousPosition = reader.BaseStream.Position;
			reader.BaseStream.Position = position;

			float value = reader.ReadSingle();

			reader.BaseStream.Position = previousPosition;

			return value;
		}

		public static void ReadLongString(this BinaryWriter writer, string value)
		{
			writer.Write(value.Length);
			writer.Write(Encoding.ASCII.GetBytes(value));
		}
	}
}
