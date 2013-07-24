using System.Collections.Generic;
using System.IO;

namespace CharacterEditor.Character
{
	public class Inventory : ICharacterData
	{
		public const int DefaultItemCount = 50;

		public List<Slot> Items;

		public Inventory()
		{
			Items = new List<Slot>();
		}

		public void Read(BinaryReader reader)
		{
			int inventoryCount = reader.ReadInt32();
			for (int i = 0; i < inventoryCount; ++i)
			{
				Slot slot = new Slot();
				slot.Read(reader);

				Items.Add(slot);
			}
		}

		public void Write(BinaryWriter writer)
		{
			writer.Write(Items.Count);

			foreach (Slot slot in Items)
				slot.Write(writer);
		}
	}
}