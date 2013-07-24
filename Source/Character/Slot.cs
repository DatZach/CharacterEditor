using System.IO;

namespace CharacterEditor.Character
{
	public class Slot : ICharacterData
	{
		public const int MaxItemCount = 50;

		public int Count;
		public Item Item;

		public void Read(BinaryReader reader)
		{
			Count = reader.ReadInt32();
			Item = new Item();
			Item.Read(reader);
		}

		public void Write(BinaryWriter writer)
		{
			writer.Write(Count);
			Item.Write(writer);
		}
	}
}
