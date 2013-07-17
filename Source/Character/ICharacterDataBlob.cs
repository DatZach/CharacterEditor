using System.IO;

namespace CharacterEditor.Character
{
	public interface ICharacterDataBlob
	{
		void Read(BinaryReader reader);
		void Write(BinaryWriter writer);
	}
}