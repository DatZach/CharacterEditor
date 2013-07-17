using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace CharacterEditor.Forms
{
	public partial class LoadCharacter : Form
	{
		// TODO Backup database just in case
		// TODO Add character delete and add?
		// TODO Add character.db merging?

		public List<Character.Character> Characters { get; private set; }
		public Character.Character SelectedCharacter { get; private set; }
		private readonly Database database;

		public LoadCharacter(Database database)
		{
			Characters = new List<Character.Character>();
			this.database = database;
			SelectedCharacter = null;

			InitializeComponent();
		}

		private void FormLoadCharacterLoad(object sender, EventArgs e)
		{
			string databasePath = FindCubeWorldDirectory();
			if (!String.IsNullOrEmpty(databasePath) && File.Exists(databasePath + @"\characters.db"))
				DatabaseLoad(databasePath + @"\characters.db");
		}

		private void ButtonLoadDatabaseClick(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog
			{
				InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86),
				Filter = "Database|characters.db",
				CheckFileExists = true,
				CheckPathExists = true
			};

			DialogResult result = dialog.ShowDialog(this);
			if (result == DialogResult.Cancel)
				return;

			DatabaseLoad(dialog.FileName);
		}

		private void ListBoxCharactersSelectedIndexChanged(object sender, EventArgs e)
		{
			if (listBoxCharacters.SelectedIndex < 0 || listBoxCharacters.SelectedIndex >= Characters.Count)
				return;

			SelectedCharacter = Characters[listBoxCharacters.SelectedIndex];
			DialogResult = DialogResult.OK;
			Close();
		}

		private void DatabaseLoad(string filename)
		{
			try
			{
				database.Load(filename);
			}
			catch (Exception e)
			{
				ExceptionDialog exceptionDialog = new ExceptionDialog("Database appears to be corrupted!", e);
				exceptionDialog.ShowDialog(this);

				return;
			}
			
			Characters.Clear();
			listBoxCharacters.Items.Clear();

			try
			{
				int characterCount = database.ReadBlobByKey("num")[0];
				for (int i = 0; i < characterCount; ++i)
				{
					Character.Character character = new Character.Character(i);
					character.Load(database);

					Characters.Add(character);
					listBoxCharacters.Items.Add(character.Name);
				}
			}
			catch (Exception e)
			{
				ExceptionDialog exceptionDialog = new ExceptionDialog("Database appears to be corrupted!", e);
				exceptionDialog.ShowDialog(this);

				Characters.Clear();
				listBoxCharacters.Items.Clear();
			}
		}

		private string FindCubeWorldDirectory()
		{
			const string cubeWorldSaveDirectory = @"\Cube World\Save";

			// Check if it exists in Registry
			string registryPath = FindCubeWorldDirectoryFromRegistry();
			if (!String.IsNullOrEmpty(registryPath))
				return registryPath;

			// Check if it exists in Program Files (32bit)
			string programFiles = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
			if (Directory.Exists(programFiles + cubeWorldSaveDirectory))
				return programFiles + cubeWorldSaveDirectory;

			// Check if it exists on the Desktop
			string desktop = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
			if (Directory.Exists(desktop + cubeWorldSaveDirectory))
				return desktop + cubeWorldSaveDirectory;

			// Can't find it
			return String.Empty;
		}

		// Credit to Ricowan
		private string FindCubeWorldDirectoryFromRegistry()
		{
			// Look in 64bit local machine
			RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall");
			if (key != null)
			{
				foreach (String keyName in key.GetSubKeyNames())
				{
					RegistryKey subKey = key.OpenSubKey(keyName);
					if (subKey == null)
						continue;

					string displayName = (string)subKey.GetValue("DisplayName");

					if (!String.IsNullOrEmpty(displayName) && displayName.StartsWith("Cube World"))
						return subKey.GetValue("InstallLocation") + @"\Save";
				}
			}

			// Look in 32bit local machine
			key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall");
			if (key != null)
			{
				foreach (String keyName in key.GetSubKeyNames())
				{
					RegistryKey subKey = key.OpenSubKey(keyName);
					if (subKey == null)
						continue;

					string displayName = (string)subKey.GetValue("DisplayName");

					if (!String.IsNullOrEmpty(displayName) && displayName.StartsWith("Cube World"))
						return subKey.GetValue("InstallLocation") + @"\Save";
				}
			}

			// Look in CurrentUser
			key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall");
			if (key != null)
			{
				foreach (string keyName in key.GetSubKeyNames())
				{
					RegistryKey subKey = key.OpenSubKey(keyName);
					if (subKey == null)
						continue;

					string displayName = (string)subKey.GetValue("DisplayName");

					if (!String.IsNullOrEmpty(displayName) && displayName.StartsWith("Cube World"))
						return subKey.GetValue("InstallLocation") + @"\Save";
				}
			}

			// Cannot find it
			return String.Empty;
		}
	}
}
