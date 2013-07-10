using System.Collections.Generic;
using System.IO;

namespace CharacterEditor
{
	public class CharacterData
	{
		// TODO There has to be a way to serialize this in a more proper .NET way

		public int DatabaseIndex { get; private set; }

		public string Name;
		public float Health;
		public int Experience;
		public int Level;
		public byte Class;
		public byte Specialization;

		public byte PetIndex;
		public int PetExperience;
		public short PetLevel;

		public int Race;
		public byte Gender;
		public int Face;
		public int Hair;
		public int HairColor;

		public int Coins;
		public int PlatinumCoins;

		// TODO Hack
		private byte[] characterData;

		// Entity IDs found at: https://docs.google.com/spreadsheet/lv?key=0As7kattQ9kwbdFp6ZTlzV0R1RVRaZklBbmZZb2lBZ2c&f=true&noheader=true&gid=5
		public static readonly List<byte> PetKinds = new List<byte>
		{
			0, 19, 20, 22, 23, 25, 26, 27, 28, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 50, 53, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 73, 74, 75, 85, 86, 87, 88, 89, 90, 91, 92, 93, 98, 99, 102, 103, 104, 105, 106, 151
		};

		public CharacterData(int index)
		{
			Name = "";
			DatabaseIndex = index;

			characterData = null;
		}

		public void Load(Database database)
		{
			characterData = database.ReadCharacterBlob(DatabaseIndex);

#if DEBUG
			using (BinaryWriter writer = new BinaryWriter(new FileStream("read.bin", FileMode.Create)))
			{
				writer.Write(characterData);
			}
#endif

			using (BinaryReader reader = new BinaryReader(new MemoryStream(characterData)))
			{
				reader.BaseStream.Seek(0x0028, SeekOrigin.Begin);
				Health = reader.ReadSingle();
				Experience = reader.ReadInt32();
				Level = reader.ReadInt32();
				Class = reader.ReadByte();
				Specialization = reader.ReadByte();

				reader.BaseStream.Seek(0x0D5E + 1, SeekOrigin.Begin);
				PetIndex = reader.ReadByte();
				reader.ReadByte();
				reader.ReadByte();
				PetExperience = reader.ReadInt32();
				reader.ReadInt32();
				reader.ReadInt32();
				PetLevel = reader.ReadInt16();

				reader.BaseStream.Seek(0x0E76, SeekOrigin.Begin);
				Name = reader.ReadLongString();
				Race = reader.ReadInt32();
				Gender = reader.ReadByte();
				reader.BaseStream.Seek(3, SeekOrigin.Current);
				Face = reader.ReadInt32();
				Hair = reader.ReadInt32();
				HairColor = reader.ReadInt32(); // ABGR

				// TODO Gotta parse the inventory to safely do this...
				Coins = 0;
				PlatinumCoins = 0;
			}
		}

		public bool Save(Database database)
		{
			MemoryStream saveDataStream = new MemoryStream();

			using (BinaryWriter writer = new BinaryWriter(saveDataStream))
			{
				Mirror(writer, 0x28);
				writer.Write(Health);
				writer.Write(Experience);
				writer.Write(Level);
				writer.Write(Class);
				writer.Write(Specialization);
				Mirror(writer, 0x0D5E - 0x36);

				if (PetIndex == 0 || PetIndex == 0xFF)
				{
					writer.Write((byte)0x00);
					writer.Write((byte)0x00);
				}
				else
				{
					writer.Write((byte)0x13);
					writer.Write(PetKinds[PetIndex]);
				}

				writer.Write((byte)0);
				writer.Write((byte)0);
				writer.Write(PetExperience);
				writer.Write(0);
				writer.Write(0);
				writer.Write(PetLevel);
				writer.Write((short)0);
				Mirror(writer, 0xE76 - 0x0D5E - 20);
				writer.ReadLongString(Name);
				writer.Write(Race);
				writer.Write(Gender);
				Mirror(writer, 3);
				writer.Write(Face);
				writer.Write(Hair);
				writer.Write(HairColor);

				// TODO We have to do this since inventory decides to be fucking stupid sometimes and just not exist
				Mirror(writer, characterData.Length - (int)writer.BaseStream.Position);

				// TODO Shouldn't be a magic number
				/*
				writer.Write(4);
				for (int i = 0; i < 4; ++i)
				{
					writer.Write(0x32);
					for (int j = 0; j < 0x32; ++j)
						Mirror(writer, 0x11C);
				}

				Mirror(writer, characterData.Length - 0xEC89 - 4);
				*/
			}

			return database.WriteCharacterBlob(DatabaseIndex, saveDataStream.ToArray());
		}

		// TODO This method is only a temporary hack, not all of the format is properly documented
		// TODO so this is a bit safer than attempted to write whatever in its place
		private void Mirror(BinaryWriter writer, int count)
		{
			// TODO This is unsafe, possible to overrun the buffer
			writer.Write(characterData, (int)writer.BaseStream.Position, count);
		}
	}

    public interface ICharacterDataBlob
    {
        void Read(BinaryReader reader);
        void Write(BinaryWriter writer);
    }
}
