using System.IO;

namespace CharacterEditor.Character
{
	public interface ICharacterData
	{
		void Read(BinaryReader reader);
		void Write(BinaryWriter writer);
	}
}