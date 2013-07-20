using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using Microsoft.Practices.ServiceLocation;
using WpfGui.Helpers;
using WpfGui.Helpers.Dialog;
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

            _dialogService = dialogService;
            var view = ServiceLocator.Current.GetInstance<SelectCharacterDialog>();
            _dialogService.ShowDialog(view,new SelectCharacterDialogViewModel(Characters), onClose => {});
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