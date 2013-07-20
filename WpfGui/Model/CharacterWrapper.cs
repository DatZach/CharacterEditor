using CharacterEditor.Character;
using GalaSoft.MvvmLight;

namespace WpfGui.Model
{
    public class CharacterWrapper : ViewModelBase
    {
        public CharacterWrapper(Character character)
        {
            Character = character;
        }

        public Character Character
        {
            get
            {
                return _character;
            }

            set
            {
                if (_character == value)
                {
                    return;
                }

                RaisePropertyChanging(CharacterPropertyName);
                _character = value;
                RaisePropertyChanged(CharacterPropertyName);
            }
        }
        public const string CharacterPropertyName = "Character";
        private Character _character;      
    
  
    }
}
