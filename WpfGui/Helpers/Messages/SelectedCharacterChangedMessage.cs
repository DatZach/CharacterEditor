using GalaSoft.MvvmLight.Messaging;
using WpfGui.Model;

namespace WpfGui.Helpers.Messages
{
    class SelectedCharacterChangedMessage : MessageBase
    {
        public SelectedCharacterChangedMessage(CharacterWrapper selectedCharacter, int index)
        {
            SelectedCharacter = selectedCharacter;
            Index = index;
        }

        public CharacterWrapper SelectedCharacter { get; set; }
        public int Index { get; set; }
    }
}
