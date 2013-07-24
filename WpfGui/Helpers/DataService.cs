using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;
using WpfGui.Model;
using CharacterEditor;

namespace WpfGui.Helpers
{
    class DataService : IDataService
    {
        public void GetData(Action<DataItem, Exception> callback)
        {
            var database = new Database();
            var characters = new ObservableCollection<CharacterWrapper>();

            try
            {
                database.Load(GetSaveFile());

                //Number of Characters is stored in the database row with key "num"
                var characterCount = database.ReadBlobByKey("num")[0];

                for (var i = 0; i < characterCount; ++i)
                {
                    var character = new CharacterWrapper(i);

                    character.Character.Load(database);
                    characters.Add(character);
                }

                callback(new DataItem(characters), null);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                throw;
            }
        }

        /// <summary>
        /// Looks into both Folders as well as Registry to find characters.db Save File
        /// </summary>
        /// <returns>File Path for character.db save file</returns>
        private static string GetSaveFile()
        {
            string[] possibleLocations =
                {
                    GetSaveFileFromFolders(),
                    GetSaveFileFromRegistry()
                };

            foreach (var saveFile in possibleLocations)
            {
                if (!String.IsNullOrEmpty(saveFile))
                    return saveFile;
            }

            // Can't find it
            return String.Empty;
        }

        /// <summary>
        /// Looks for the characters.db save file in 3 possible locations within the registry
        /// </summary>
        /// <returns>File Path for character.db save file</returns>
        private static string GetSaveFileFromFolders()
        {
            const string saveFileLocation = @"\Cube World\Save\characters.db";

            string[] possibleLocations =
                {
                    Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86),
                    Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
                };
            foreach (var parentFolder in possibleLocations)
            {
                var saveFile = parentFolder + saveFileLocation;

                if (!String.IsNullOrEmpty(saveFile)
                    && File.Exists(saveFile))
                    return saveFile;
            }

            return String.Empty;
        }

        /// <summary>
        /// Looks for the characters.db save file in x86, x64 Local Machine as well as CurrentUser within the registry
        /// </summary>
        /// <returns>File Path for character.db save file</returns>
        private static string GetSaveFileFromRegistry()
        {
            RegistryKey[] possibleKeys =
                {
                    Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall"),
                    Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall"),
                    Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall")
                };

            
            foreach(var key in possibleKeys)
            {
                if (key == null) continue;
                foreach (var keyName in key.GetSubKeyNames())
                {
                    var subKey = key.OpenSubKey(keyName);
                    if (subKey == null)
                        continue;

                    var displayName = (string) subKey.GetValue("DisplayName");
                    var saveFileDirectory = subKey.GetValue("InstallLocation");
                    var saveFilePath = String.Format("{0}\\Save\\characters.db",saveFileDirectory);

                    if (!String.IsNullOrEmpty(displayName) 
                        && displayName.StartsWith("Cube World")
                        && File.Exists(saveFilePath))
                        return saveFilePath;
                }
            }

            // Cannot find it
            return String.Empty;
        }
    }
}
