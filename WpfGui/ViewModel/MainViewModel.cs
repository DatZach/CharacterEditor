using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.Practices.ServiceLocation;
using WpfGui.Helpers;
using WpfGui.Helpers.Dialog;
using WpfGui.Helpers.Messages;
using WpfGui.Model;
using WpfGui.Views;

namespace WpfGui.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IDataService _dataService;
        private readonly IModalDialogService _dialogService;

        public MainViewModel(IDataService dataService, IModalDialogService dialogService)
        {
            _dataService = dataService;
            _dataService.GetData(
                (item, error) =>
                    {
                        if (error != null)
                        {
                            // Report error here
                            return;
                        }
                        Characters = item.Characters;
                    });
            //Temp Hack
            SelectedCharacter = Characters[0];

            if (IsInDesignMode)
            {
                return;
            }

            //Dialog
            _dialogService = dialogService;
            var view = ServiceLocator.Current.GetInstance<SelectCharacterDialog>();
            _dialogService.ShowDialog(view, ServiceLocator.Current.GetInstance<SelectCharacterDialogViewModel>());

            Messenger.Default.Register(this, delegate(SelectedCharacterChangedMessage message)
                {
                    SelectedCharacter =
                        message.SelectedCharacter;
                });
        }

        #region Properties

        public const string CharactersPropertyName = "Characters";

        public const string SelectedCharacterPropertyName = "SelectedCharacter";
        private ObservableCollection<CharacterWrapper> _characters;
        private CharacterWrapper _selectedCharacter;

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

                RaisePropertyChanging(SelectedCharacterPropertyName);
                _selectedCharacter = value;
                RaisePropertyChanged(SelectedCharacterPropertyName);
            }
        }

        #endregion Properties
    }
}