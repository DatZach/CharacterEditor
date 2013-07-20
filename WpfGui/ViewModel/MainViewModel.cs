using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using WpfGui.Helpers;
using WpfGui.Model;

namespace WpfGui.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IDataService _dataService;      
        
        public MainViewModel(IDataService dataService)
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