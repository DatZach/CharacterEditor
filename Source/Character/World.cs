using System.IO;

namespace CharacterEditor.Character
{
	public class World : ICharacterData
	{
		public int Seed;
		public string Name;
		public long X;
		public long Y;
		public long Z;

		public void Read(BinaryReader reader)
		{
			Seed = reader.ReadInt32();
			Name = reader.ReadLongString();
			X = reader.ReadInt64();
			Y = reader.ReadInt64();
			Z = reader.ReadInt64();
		}

		public void Write(BinaryWriter writer)
		{
			writer.Write(Seed);
			writer.WriteLongString(Name);
			writer.Write(X);
			writer.Write(Y);
			writer.Write(Z);
		}
	}
}