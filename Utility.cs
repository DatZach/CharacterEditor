using System;
using System.Drawing;
using System.IO;
using System.Text;

namespace CharacterEditor
{
	static class Utility
	{
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

		// TODO Refactor this
		public static string GetCubeWorldDirectory()
		{
			string programFiles = Environment.GetEnvironmentVariable(
				!String.IsNullOrEmpty(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432"))
					? "ProgramFiles(x86)"
					: "ProgramFiles"
				);

			if (Directory.Exists(programFiles + @"\Cube World"))
				return programFiles + @"\Cube World\";

			return programFiles;
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

		public static void ReadLongString(this BinaryWriter writer, string value)
		{
			writer.Write(value.Length);
			writer.Write(Encoding.ASCII.GetBytes(value));
		}
	}
}
