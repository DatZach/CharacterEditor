using System.IO;

namespace CharacterEditor.Character
{
	public class ItemAttribute : ICharacterData
	{
		public byte OffsetX;
		public byte OffsetY;
		public byte OffsetZ;
		public byte Material;
		public short Level;

		public bool Used
		{
			get
			{
				return OffsetX + OffsetY + OffsetZ + Material + Level > 0;
			}
		}

		public void Read(BinaryReader reader)
		{
			OffsetX = reader.ReadByte();
			OffsetY = reader.ReadByte();
			OffsetZ = reader.ReadByte();
			Material = reader.ReadByte();
			Level = reader.ReadInt16();
			reader.Skip(2);
		}

		public void Write(BinaryWriter writer)
		{
			writer.Write(OffsetX);
			writer.Write(OffsetY);
			writer.Write(OffsetZ);
			writer.Write(Material);
			writer.Write(Level);
			writer.Skip(2);
		}
	}
}