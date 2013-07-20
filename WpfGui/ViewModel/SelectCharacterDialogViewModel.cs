using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using WpfGui.Model;

namespace WpfGui.ViewModel
{
    public class SelectCharacterDialogViewModel : ViewModelBase
    {
        public SelectCharacterDialogViewModel(ObservableCollection<Model.CharacterWrapper> characters)
        {
            Characters = characters;
        }

        #region Properties

       public ObservableCollection<CharacterWrapper> Characters
        {
            get
            {
                return _characters;
            }

            set
            {
                if (_characters == value)
                {
                    return;
                }

                RaisePropertyChanging(CharactersPropertyName);
                _characters = value;
                RaisePropertyChanged(CharactersPropertyName);
            }
        }
        public const string CharactersPropertyName = "Characters";
        private ObservableCollection<CharacterWrapper> _characters;      
  

        #endregion Properties
    }
}
