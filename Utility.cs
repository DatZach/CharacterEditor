using System;
using System.Drawing;
using System.IO;
using System.Text;

namespace CharacterEditor
{
	static class Utility
	{
		public static int GoofyIndex(int index, string[] list)
		{
			int result = index;

			for (int i = 0, j = 0; i <= index; ++i, ++j)
			{
				if (j >= list.Length)
					break;

				while (String.IsNullOrEmpty(list[j]))
				{
					++result;
					++j;
				}
			}

			return result;
		}

		public static int NormalizeIndex(int index, string[] list)
		{
			int result = 0;

			for (int i = 0; i < index; ++i)
			{
				if (i >= list.Length)
					return 0;

				if (String.IsNullOrEmpty(list[i]))
					continue;

				++result;
			}
			
			return result;
		}

		public static Color FromAbgr(int abgr)
		{
			int value = (int)(abgr & 0xFF00FF00);
			value |= (abgr & 0x000000FF) << 16;
			value |= (abgr & 0x00FF0000) >> 16;

			return Color.FromArgb(value);
		}

		public static int ToAbgr(Color color)
		{
			int argb = color.ToArgb();
			int value = (int)(argb & 0xFF00FF00);
			value |= (argb & 0x000000FF) << 16;
			value |= (argb & 0x00FF0000) >> 16;

			return value;
		}

		public static void Skip(this BinaryReader reader, int count)
		{
			reader.BaseStream.Seek(count, SeekOrigin.Current);
		}

		public static void Skip(this BinaryWriter writer, int count)
		{
			writer.Write(new byte[count]);
		}

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

		public static void WriteLongString(this BinaryWriter writer, string value)
		{
			writer.Write(value.Length);
			writer.Write(Encoding.ASCII.GetBytes(value));
		}
	}
}
