using System;
using System.Collections.ObjectModel;
using System.Text;

namespace WpfGui.Model
{
    public class DataItem
    {
        public DataItem(ObservableCollection<CharacterWrapper> characters)
        {
            Characters = characters;
        }

        public ObservableCollection<CharacterWrapper> Characters
        {
            get;
            private set;
        }
    }
}
