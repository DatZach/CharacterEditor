using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace CharacterEditor
{
	public class CharacterData
	{
		public const int EquipmentCount = 13;
		public const int InventoryCount = 4;
		public const int SkillCount = 11;

		public enum ClassType : byte
		{
			None,
			Warrior,
			Ranger,
			Mage,
			Rogue
		};

		public int DatabaseIndex { get; private set; }

		public int EntityId { get; private set; }
		public double PositionX { get; private set; }
		public double PositionY { get; private set; }
		public double PositionZ { get; private set; }
		public float Pitch { get; private set; }
		public float Roll { get; private set; }
		public float Yaw { get; private set; }

		public float Health;
		public int Experience;
		public int Level;
		public ClassType Class;
		public byte Specialization;

		private uint unknown1;
		private uint unknown2;

		public List<Item> Equipment;

		public string Name;
		public int Race;
		public byte Gender;
		public int Face;
		public int Hair;
		public Color HairColor;

		public List<Inventory> Inventories;

		public int Coins;
		public int PlatinumCoins;

		public List<Item> CraftingRecipes;
		public List<World> Worlds;
		public World LastWorld;

		private uint unknown3;
		public int PetMasterSkillLevel;
		public int PetRidingSkillLevel;
		public int ClimbingSkillLevel;
		public int HangGlidingSkillLevel;
		public int SwimmingSkillLevel;
		public int SailingSkillLevel;
		public int TierOneSkillLevel;
		public int TierTwoSkillLevel;
		public int TierThreeSkillLevel;
		private int unknown4;
		private int unknown5;

		// Entity IDs found at: https://docs.google.com/spreadsheet/lv?key=0As7kattQ9kwbdFp6ZTlzV0R1RVRaZklBbmZZb2lBZ2c&f=true&noheader=true&gid=5
		public static readonly List<byte> PetKinds = new List<byte>
		{
			0, 19, 20, 22, 23, 25, 26, 27, 28, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 50, 53, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 73, 74, 75, 85, 86, 87, 88, 89, 90, 91, 92, 93, 98, 99, 102, 103, 104, 105, 106, 151
		};

		public CharacterData(int index)
		{
			DatabaseIndex = index;

			Equipment = new List<Item>();
			Inventories = new List<Inventory>();
			CraftingRecipes = new List<Item>();
			Worlds = new List<World>();
		}

		public void Load(Database database)
		{
			byte[] characterData = database.ReadCharacterBlob(DatabaseIndex);

			using (BinaryReader reader = new BinaryReader(new MemoryStream(characterData)))
				Read(reader);
		}

		public bool Save(Database database)
		{
			MemoryStream saveDataStream = new MemoryStream();

			using (BinaryWriter writer = new BinaryWriter(saveDataStream))
				Write(writer);

			return database.WriteCharacterBlob(DatabaseIndex, saveDataStream.ToArray());
		}

		public void Read(BinaryReader reader)
		{
			EntityId = reader.ReadInt32();
			PositionX = reader.ReadDouble();
			PositionY = reader.ReadDouble();
			PositionZ = reader.ReadDouble();
			Pitch = reader.ReadSingle();
			Roll = reader.ReadSingle();
			Yaw = reader.ReadSingle();

			Health = reader.ReadSingle();
			Experience = reader.ReadInt32();
			Level = reader.ReadInt32();
			Class = (ClassType)reader.ReadByte();
			Specialization = reader.ReadByte();
			unknown1 = reader.ReadUInt32();
			unknown2 = reader.ReadUInt32();

			for(int i = 0; i < EquipmentCount; ++i)
			{
				Item item = new Item();
				item.Read(reader);

				Equipment.Add(item);
			}

			Name = reader.ReadLongString();
			Race = reader.ReadInt32();
			Gender = reader.ReadByte();
			reader.Skip(3);
			Face = reader.ReadInt32();
			Hair = reader.ReadInt32();
			HairColor = Utility.FromAbgr(reader.ReadInt32());

			int inventoryCount = reader.ReadInt32();
			for(int i = 0; i < inventoryCount; ++i)
			{
				Inventory inventory = new Inventory();
				inventory.Read(reader);

				Inventories.Add(inventory);
			}

			Coins = reader.ReadInt32();
			PlatinumCoins = reader.ReadInt32();

			int craftingRecipeCount = reader.ReadInt32();
			for(int i = 0; i < craftingRecipeCount; ++i)
			{
				Item item = new Item();
				item.Read(reader);

				CraftingRecipes.Add(item);
			}

			int worldCount = reader.ReadInt32();
			for(int i = 0; i < worldCount; ++i)
			{
				World world = new World();
				world.Read(reader);

				Worlds.Add(world);
			}

			int lastWorldSeed = reader.ReadInt32();
			string lastWorldName = reader.ReadLongString();

			LastWorld = Worlds.FirstOrDefault(w => w.Seed == lastWorldSeed && w.Name == lastWorldName);

			unknown3 = reader.ReadUInt32();
			reader.ReadInt32();
			PetMasterSkillLevel = reader.ReadInt32();
			PetRidingSkillLevel = reader.ReadInt32();
			ClimbingSkillLevel = reader.ReadInt32();
			HangGlidingSkillLevel = reader.ReadInt32();
			SwimmingSkillLevel = reader.ReadInt32();
			SailingSkillLevel = reader.ReadInt32();
			TierOneSkillLevel = reader.ReadInt32();
			TierTwoSkillLevel = reader.ReadInt32();
			TierThreeSkillLevel = reader.ReadInt32();
			unknown4 = reader.ReadInt32();
			unknown5 = reader.ReadInt32();
		}

		public void Write(BinaryWriter writer)
		{
			writer.Write(EntityId);
			writer.Write(PositionX);
			writer.Write(PositionY);
			writer.Write(PositionZ);
			writer.Write(Pitch);
			writer.Write(Roll);
			writer.Write(Yaw);

			writer.Write(Health);
			writer.Write(Experience);
			writer.Write((byte)Class);
			writer.Write(Specialization);
			writer.Write(unknown1);
			writer.Write(unknown2);

			foreach(Item equipment in Equipment)
				equipment.Write(writer);

			writer.WriteLongString(Name);
			writer.Write(Race);
			writer.Write(Gender);
			writer.Skip(3);
			writer.Write(Face);
			writer.Write(Hair);
			writer.Write(Utility.ToAbgr(HairColor));

			writer.Write(InventoryCount);
			foreach(Inventory inventory in Inventories)
				inventory.Write(writer);

			writer.Write(Coins);
			writer.Write(PlatinumCoins);

			writer.Write(CraftingRecipes.Count);
			foreach(Item recipe in CraftingRecipes)
				recipe.Write(writer);

			writer.Write(LastWorld.Seed);
			writer.Write(LastWorld.Name);

			writer.Write(unknown3);
			writer.Write(SkillCount);
			writer.Write(PetMasterSkillLevel);
			writer.Write(PetRidingSkillLevel);
			writer.Write(ClimbingSkillLevel);
			writer.Write(HangGlidingSkillLevel);
			writer.Write(SwimmingSkillLevel);
			writer.Write(SailingSkillLevel);
			writer.Write(TierOneSkillLevel);
			writer.Write(TierTwoSkillLevel);
			writer.Write(TierThreeSkillLevel);
			writer.Write(unknown4);
			writer.Write(unknown5);
		}
	}

    public interface ICharacterDataBlob
    {
        void Read(BinaryReader reader);
        void Write(BinaryWriter writer);
    }

	public class Item : ICharacterDataBlob
	{
		public const int AttributeCount = 31;

		public enum ItemType : byte
		{
			None,
			Consumable,
			Formula,
			Weapon,
			ChestArmor,
			Gloves,
			Boots,
			ShoulderArmor,
			Amulet,
			Ring,
			Spirit,
			Nugget,
			Coin,
			PlatinumCoin,
			Leftovers,
			Beak,
			Painting,
			Vase,
			Candle,
			Pet,
			PetFood,
			QuestItem,
			Unknown,
			Transportation,
			Lamp
		};

		public ItemType Type;
		public byte Subtype;
		public short Modifier;
		private long unknown1;
		public byte Rarity;
		public byte Material;
		public byte Flags;
		public short Level;

		public List<ItemAttribute> Attributes;

		public Item()
		{
			Attributes = new List<ItemAttribute>();
		}

		public void Read(BinaryReader reader)
		{
			Type = (ItemType)reader.ReadByte();
			Subtype = reader.ReadByte();
			reader.Skip(2);
			Modifier = reader.ReadInt16();
			reader.Skip(2);
			unknown1 = reader.ReadInt64();
			Rarity = reader.ReadByte();
			Material = reader.ReadByte();
			Flags = reader.ReadByte();
			reader.Skip(1);
			Level = reader.ReadInt16();
			reader.Skip(2);

			for(int i = 0; i < AttributeCount; ++i)
			{
				ItemAttribute attribute = new ItemAttribute();
				attribute.Read(reader);

				Attributes.Add(attribute);
			}

			// AttributesUsed is calculated on write
			reader.Skip(8);
		}

		public void Write(BinaryWriter writer)
		{
			writer.Write((byte)Type);
			writer.Write(Subtype);
			writer.Skip(2);
			writer.Write(Modifier);
			writer.Write(unknown1);
			writer.Write(Rarity);
			writer.Write(Material);
			writer.Write(Flags);
			writer.Skip(1);
			writer.Write(Level);
			writer.Skip(2);

			foreach (ItemAttribute attribute in Attributes)
				attribute.Write(writer);

			writer.Write(0);
			writer.Write(Attributes.Count(attr => attr.Used));
		}
	}

	public class ItemAttribute : ICharacterDataBlob
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

	public class Inventory : ICharacterDataBlob
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
			for(int i = 0; i < inventoryCount; ++i)
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

	public class World : ICharacterDataBlob
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
