using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using WpfGui.Helpers;
using WpfGui.Helpers.Messages;
using WpfGui.Model;

namespace WpfGui.ViewModel
{
    public class SelectCharacterDialogViewModel : ViewModelBase
    {
        public const string CharactersPropertyName = "Characters";
        public const string SelectCharacterPropertyName = "SelectedCharacter";
        private readonly IDataService _dataService;
        private ObservableCollection<CharacterWrapper> _characters;
        private CharacterWrapper _selectedCharacter;

        public SelectCharacterDialogViewModel(IDataService dataService)
        {
            _dataService = dataService;
            _dataService.GetData((item, error) =>
                {
                    if (error != null)
                    {
                        // Report error here
                        return;
                    }
                    Characters = item.Characters;
                });

            //Notifies MainViewModel of a change in selected Character
            SelectCharacterCommand = new RelayCommand(SendSelectedCharacterChangedMessage);
        }

        public ObservableCollection<CharacterWrapper> Characters
        {
            get { return _characters; }

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

        public CharacterWrapper SelectedCharacter
        {
            get { return _selectedCharacter; }

            set
            {
                if (_selectedCharacter == value)
                {
                    return;
                }

                RaisePropertyChanging(SelectCharacterPropertyName);
                _selectedCharacter = value;
                RaisePropertyChanged(SelectCharacterPropertyName);
            }
        }

        public RelayCommand SelectCharacterCommand { get; private set; }

        public void SendSelectedCharacterChangedMessage()
        {
            Messenger.Default.Send(
                new SelectedCharacterChangedMessage(
                    SelectedCharacter, Characters.IndexOf(SelectedCharacter)));
            Messenger.Default.Send(new CloseSelectCharacterDialogMessage());
        }
    }
}