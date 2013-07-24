using System;
using System.Collections.ObjectModel;
using WpfGui.Helpers;
using WpfGui.Model;

namespace WpfGui.Design
{
    public class DesignDataService : IDataService
    {
        public void GetData(Action<DataItem, Exception> callback)
        {
            var characters = new ObservableCollection<CharacterWrapper>();
            var character = new CharacterWrapper
                {
                    Character = CharacterFactory.CreateMockCharacter()
                };
            characters.Add(character);

            callback(new DataItem(characters), null);
        }
    }
}
