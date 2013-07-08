using System.IO;
using System.Windows.Forms;

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
		public int PetXp;
		public int PetLevel;

		public int Race;
		public byte Gender;
		public int Face;
		public int Hair;
		public uint HairColor;

		// TODO Hack
		private byte[] characterData;

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

				reader.BaseStream.Seek(0x0E76, SeekOrigin.Begin);
				Name = reader.ReadLongString();
				Race = reader.ReadInt32();
				Gender = reader.ReadByte();
				reader.BaseStream.Seek(3, SeekOrigin.Current);
				Face = reader.ReadInt32();
				Hair = reader.ReadInt32();
				HairColor = reader.ReadUInt32();
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
				Mirror(writer, 0x0E76 - 0x36);
				writer.ReadLongString(Name);
				writer.Write(Race);
				writer.Write(Gender);
				Mirror(writer, 3);
				writer.Write(Face);
				writer.Write(Hair);
				writer.Write(HairColor);

				// TODO Shouldn't be a magic number
				writer.Write(4);
				for(int i = 0; i < 4; ++i)
				{
					writer.Write(0x32);
					for(int j = 0; j < 0x32; ++j)
						Mirror(writer, 0x11C);
				}

				Mirror(writer, characterData.Length - 0xEC89 - 4);
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
}
