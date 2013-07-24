using CharacterEditor.Character;
using GalaSoft.MvvmLight;

namespace WpfGui.Model
{
    public class CharacterWrapper : ViewModelBase
    {
        public CharacterWrapper() : this(0)
        {
        }

        public CharacterWrapper(int i)
        {
            Character = new Character(i);
        }

        #region Properties

        public const string CharacterPropertyName = "Character";
        public const string NamePropertyName = "Name";
        public const string ClassTypePropertyName = "ClassType";
        public const string ClassNamePropertyName = "ClassName";
        public const string LevelPropertyName = "Level";
        public const string LevelStringPropertyName = "LevelString";
        public const string LastWorldPlayedPropertyName = "LastWorldPlayed";
        public const string LastWorldNamePropertyName = "LastWorldName";
        private Character _character;

        public Character Character
        {
            get { return _character; }

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

        public string Name
        {
            get { return Character.Name; }

            set
            {
                if (Character.Name == value)
                {
                    return;
                }

                RaisePropertyChanging(NamePropertyName);
                Character.Name = value;
                RaisePropertyChanged(NamePropertyName);
            }
        }

        public Character.ClassType ClassType
        {
            get { return Character.Class; }

            set
            {
                if (Character.Class == value)
                {
                    return;
                }

                RaisePropertyChanging(ClassTypePropertyName);
                Character.Class = value;
                RaisePropertyChanged(ClassTypePropertyName);
                RaisePropertyChanged(ClassNamePropertyName);
            }
        }

        public string ClassName
        {
            get { return ClassType.ToString(); }
        }

        public int Level
        {
            get { return Character.Level; }

            set
            {
                if (Character.Level == value)
                {
                    return;
                }

                RaisePropertyChanging(LevelPropertyName);
                Character.Level = value;
                RaisePropertyChanged(LevelPropertyName);
                RaisePropertyChanged(LevelStringPropertyName);
            }
        }

        public string LevelString
        {
            get { return string.Format("Level {0}", Level.ToString()); }
        }

        public World LastWorldPlayed
        {
            get { return Character.LastWorld; }

            set
            {
                if (Character.LastWorld == value)
                {
                    return;
                }

                RaisePropertyChanging(LastWorldPlayedPropertyName);
                Character.LastWorld = value;
                RaisePropertyChanged(LastWorldPlayedPropertyName);
            }
        }

        public string LastWorldName
        {
            get { return ("World: " + LastWorldPlayed.Name); }
        }

        #endregion
    }
}