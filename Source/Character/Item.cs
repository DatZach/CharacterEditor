using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CharacterEditor.Character
{
	public class Item : ICharacterData
	{
		public const int AttributeCount = 32;
		public const int PrefixDivisor = 10;
		public const int ModelDivisor = 11;
		public const int EffectDivisor = 21;

		public byte Type;
		public byte Subtype;
		//public short ActualModifier; // TODO Hack, should build modifier from its fragments
		public byte RecipeType;
		public byte Rarity;
		public byte Material;
		public ItemFlags Flags;
		public short Level;

		// Modifier subparts
		public int PrefixId;
		public int ModelId;
		public int EffectId;

		public List<ItemAttribute> Attributes;

		public double Armor
		{
			get
			{
				HashSet<Constants.ItemType> supportedTypes = new HashSet<Constants.ItemType>
				{
					Constants.ItemType.ChestArmor,
					Constants.ItemType.ShoulderArmor,
					Constants.ItemType.Gloves,
					Constants.ItemType.Boots
				};

				Constants.ItemType itemType = (Constants.ItemType)Type;

				if (!supportedTypes.Contains(itemType))
					return 0.0;

				double typeBonus = itemType == Constants.ItemType.ChestArmor ? 1.0 : 0.5;

				double materialBonus = 0;
				switch (Material)
				{
					case 23:
					case 25:
						materialBonus = 0.075;
						break;

					case 19:
					case 26:
					case 27:
						materialBonus = 0.85; // might need to expand the precision here
						break;

					case 18:
						materialBonus = 0.80; // might need to expand the precision here
						break;
				}

				double effect = CalculateLevelEffectValue(Level + Attributes.Count / 10.0, Rarity);
				return effect * typeBonus * materialBonus;
			}
		}

		public double Critical
		{
			get
			{
				HashSet<Constants.ItemType> supportedTypes = new HashSet<Constants.ItemType>
				{
					Constants.ItemType.Amulets,
					Constants.ItemType.Rings,
					Constants.ItemType.Weapons,
					Constants.ItemType.ChestArmor,
					Constants.ItemType.ShoulderArmor,
					Constants.ItemType.Gloves,
					Constants.ItemType.Boots
				};

				Constants.ItemType itemType = (Constants.ItemType)Type;

				if (!supportedTypes.Contains(itemType))
					return 0.0;

				double typeBonus = 0.05;
				if (itemType == Constants.ItemType.Weapons && (Subtype == 15 || Subtype == 16 || Subtype == 17 ||
								  Subtype == 5 || Subtype == 10 || Subtype == 11 ||
								  Subtype == 18 || Subtype == 8 || Subtype == 6 || Subtype == 7) ||
					itemType == Constants.ItemType.ChestArmor)
						typeBonus = 0.1;

				double modifierBonus = 1.0 - ((Modifier % 21) / 20.0);
				if (Material == 11)
					modifierBonus += 1.0;

				double effect = CalculateLevelEffectPercent(Level, Rarity);
				double result = effect * typeBonus * modifierBonus;

				return Math.Abs(result) < 0.001 ? 0 : result;
			}
		}

		public double Life
		{
			get
			{
				HashSet<Constants.ItemType> supportedTypes = new HashSet<Constants.ItemType>
				{
					Constants.ItemType.Weapons,
					Constants.ItemType.ChestArmor,
					Constants.ItemType.ShoulderArmor,
					Constants.ItemType.Gloves,
					Constants.ItemType.Boots
				};

				Constants.ItemType itemType = (Constants.ItemType)Type;

				if (!supportedTypes.Contains(itemType))
					return 0.0;

				double typeBonus = itemType == Constants.ItemType.ChestArmor ? 1.0 : 0.5;
				double modifierBonus = (1.0 - ((Modifier % 21) / 20.0)) + 1.0;

				switch (Material)
				{
					case 1:
						modifierBonus += 1.0;
						break;

					case 26:
						modifierBonus += 0.5;
						break;

					case 27:
						modifierBonus += 0.75;
						break;
				}

				double effect = CalculateLevelEffectValue(Level + Attributes.Count / 10.0, Rarity);
				return effect * 5.0 * typeBonus * modifierBonus;
			}
		}

		public double Regeneration
		{
			get
			{
				HashSet<Constants.ItemType> supportedTypes = new HashSet<Constants.ItemType>
				{
					Constants.ItemType.Weapons,
					Constants.ItemType.ChestArmor,
					Constants.ItemType.ShoulderArmor,
					Constants.ItemType.Gloves,
					Constants.ItemType.Boots
				};

				Constants.ItemType itemType = (Constants.ItemType)Type;

				if (!supportedTypes.Contains(itemType))
					return 0.0;

				double typeBonus = itemType == Constants.ItemType.ChestArmor ? 0.2 : 0.1;
				double modifierBonus = (Modifier % 21) / 20.0;

				switch (Material)
				{
					case 26:
						modifierBonus += 0.5;
						break;

					case 27:
						modifierBonus += 1.0;
						break;
				}

				double effect = CalculateLevelEffectValue(Level + Attributes.Count / 10.0, Rarity);
				return effect * typeBonus * modifierBonus;
			}
		}

		public double Resistance
		{
			get
			{
				HashSet<Constants.ItemType> supportedTypes = new HashSet<Constants.ItemType>
				{
					Constants.ItemType.ChestArmor,
					Constants.ItemType.ShoulderArmor,
					Constants.ItemType.Gloves,
					Constants.ItemType.Boots
				};

				Constants.ItemType itemType = (Constants.ItemType)Type;

				if (!supportedTypes.Contains(itemType))
					return 0.0;

				double typeBonus = itemType == Constants.ItemType.ChestArmor ? 1.0 : 0.5;

				double materialBonus = 0.0;
				switch (Material)
				{
					case 1:
					case 19:
						materialBonus = 0.85;
						break;

					case 26:
					case 27:
						materialBonus = 0.75;
						break;
				}

				double effect = CalculateLevelEffectValue(Level + Attributes.Count / 10.0, Rarity);
				return effect * typeBonus * materialBonus;
			}
		}

		public double Tempo
		{
			get
			{
				HashSet<Constants.ItemType> supportedTypes = new HashSet<Constants.ItemType>
				{
					Constants.ItemType.Amulets,
					Constants.ItemType.Rings,
					Constants.ItemType.Weapons,
					Constants.ItemType.ChestArmor,
					Constants.ItemType.ShoulderArmor,
					Constants.ItemType.Gloves,
					Constants.ItemType.Boots
				};

				Constants.ItemType itemType = (Constants.ItemType)Type;

				if (!supportedTypes.Contains(itemType))
					return 0.0;

				double typeBonus = 0.1;
				if (itemType == Constants.ItemType.Weapons && (Subtype == 15 || Subtype == 16 || Subtype == 17 ||
								  Subtype == 5 || Subtype == 10 || Subtype == 11 ||
								  Subtype == 18 || Subtype == 8 || Subtype == 6 || Subtype == 7) ||
					itemType == Constants.ItemType.ChestArmor)
						typeBonus = 0.2;

				double modifierBonus = (Modifier % 21) / 20.0;
				if (Material == 12)
					modifierBonus += 1.0;

				double effect = CalculateLevelEffectPercent(Level, Rarity);
				double result = effect * typeBonus * modifierBonus;

				return Math.Abs(result) < 0.001 ? 0 : result;

			}
		}

		public double Damage
		{
			get
			{
				Constants.ItemType itemType = (Constants.ItemType)Type;

				if (itemType != Constants.ItemType.Weapons)
					return 0.0;

				double damageBonus = 4.0;
				switch (Subtype)
				{
					case 3:
					case 4:
						damageBonus = 2.0;
						break;

					case 5:
						damageBonus = 4.0;
						break;

					case 13:
						damageBonus = 2.0;
						break;

					case 15:
					case 16:
					case 17:
					case 10:
					case 11:
					case 18:
					case 8:
					case 6:
					case 7:
						damageBonus = 8.0;
						break;
				}

				double effect = CalculateLevelEffectValue(Level + Attributes.Count / 10.0, Rarity);
				return effect * damageBonus;
			}
		}

		public short Modifier
		{
			get
			{
				int modifier, t;
				ChineseRemainder.Solve(PrefixDivisor, ModelDivisor, EffectDivisor, PrefixId, ModelId, EffectId, out modifier, out t);

				return (short)modifier;
			}

			private set
			{
				PrefixId = value % PrefixDivisor;
				ModelId = value % ModelDivisor;
				EffectId = value % EffectDivisor;
			}
		}

		public string FriendlyName
		{
			get
			{
				try
				{
					// TODO Should probably clean this up
					string format = "{0}";

					string ownerName = NameGenerator.Generate(Modifier, (Modifier * 7) % 11);
					string itemName = string.Empty;

					if (Type == (int)Constants.ItemType.Recipes)
					{
						itemName += Constants.ItemSubtypes[RecipeType][Subtype] + " ";
						itemName += Constants.ItemSubtypes[(int)Constants.ItemType.Recipes][Subtype];
					}
					else
						itemName += Constants.ItemSubtypes[Type][Subtype];

					if (Material != 0)
						itemName = Constants.ItemMaterialNames[Material] + " " + itemName;

					if (Modifier != 0)
						format = Constants.ItemModifiers[Rarity][(Modifier - 1) % 10];

					return Rarity < 3 ? string.Format(format, itemName) : string.Format(format, itemName, ownerName);
				}
				catch (Exception)
				{
					return "ERROR";
				}
			}
		}

		[Flags]
		public enum ItemFlags : byte
		{
			Adapted = 0x01
		}

		public Item()
		{
			Attributes = new List<ItemAttribute>();
		}

		public void Read(BinaryReader reader)
		{
			Type = reader.ReadByte();
			Subtype = reader.ReadByte();
			reader.Skip(2);
			Modifier = reader.ReadInt16();
			reader.Skip(2);
			RecipeType = reader.ReadByte();
			reader.Skip(3);
			Rarity = reader.ReadByte();
			Material = reader.ReadByte();
			Flags = (ItemFlags)reader.ReadByte();
			reader.Skip(1);
			Level = reader.ReadInt16();
			reader.Skip(2);

			for (int i = 0; i < AttributeCount; ++i)
			{
				ItemAttribute attribute = new ItemAttribute();
				attribute.Read(reader);

				Attributes.Add(attribute);
			}

			// AttributesUsed is calculated on write
			reader.Skip(4);
		}

		public void Write(BinaryWriter writer)
		{
			writer.Write(Type);
			writer.Write(Subtype);
			writer.Skip(2);
			writer.Write(Modifier);
			writer.Skip(2);
			writer.Write(RecipeType);
			writer.Skip(3);
			writer.Write(Rarity);
			writer.Write(Material);
			writer.Write((byte)Flags);
			writer.Skip(1);
			writer.Write(Level);
			writer.Skip(2);

			foreach (ItemAttribute attribute in Attributes)
				attribute.Write(writer);

			writer.Write(Attributes.Count(attr => attr.Used));
		}

		private static double CalculateLevelEffectValue(double level, int rarity)
		{
			double a = 3.0 * (1.0 - (1.0 / (1.0 + ((level - 1.0) / 20.0))));
			double b = rarity / 4.0;
			double result = Math.Pow(2, a) * Math.Pow(2, b);

			return result;
		}

		private static double CalculateLevelEffectPercent(double level, int rarity)
		{
			double a = 3.0 * (1.0 - (1.0 / (1.0 + ((level - 1.0) / 20.0))));
			double b = rarity / 4.0;
			double c = 3.0;
			double result = Math.Pow(2, a) * Math.Pow(2, b) / Math.Pow(2, c);

			return result;
		}
	}
}