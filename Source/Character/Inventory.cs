using System;
using System.Collections.Generic;
using System.IO;

namespace CharacterEditor.Character
{
	public class Inventory : ICharacterData
	{
		public const int DefaultItemCount = 50;

		public List<Tuple<int, Item>> Items;

		public Inventory()
		{
			Items = new List<Tuple<int, Item>>();
		}

		public void Read(BinaryReader reader)
		{
			int inventoryCount = reader.ReadInt32();
			for (int i = 0; i < inventoryCount; ++i)
			{
				int count = reader.ReadInt32();
				Item item = new Item();
				item.Read(reader);

				Items.Add(new Tuple<int, Item>(count, item));
			}
		}

		public void Write(BinaryWriter writer)
		{
			writer.Write(Items.Count);

			foreach (Tuple<int, Item> item in Items)
			{
				writer.Write(item.Item1);
				item.Item2.Write(writer);
			}
		}
	}
}