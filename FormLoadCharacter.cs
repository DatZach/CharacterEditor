using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CharacterEditor
{
	public partial class FormLoadCharacter : Form
	{
		// TODO Backup database just in case

		public List<CharacterData> Characters { get; private set; }
		public CharacterData SelectedCharacter { get; private set; }
		private readonly Database database;

		public FormLoadCharacter(Database database)
		{
			Characters = new List<CharacterData>();
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
			catch (Exception)
			{
				MessageBox.Show("Database appears to be corrupted!", "Character Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Characters.Clear();
			listBoxCharacters.Items.Clear();

			try
			{
				int characterCount = database.ReadBlobByKey("num")[0];
				for (int i = 0; i < characterCount; ++i)
				{
					CharacterData character = new CharacterData(i);
					character.Load(database);

					Characters.Add(character);
					listBoxCharacters.Items.Add(character.Name);
				}
			}
			catch (Exception exception)
			{
				StringBuilder message = new StringBuilder();
				message.AppendLine("Database appears to be corrupted!");
				message.AppendLine(exception.Message);
				message.AppendLine(exception.Source);
				message.AppendLine(exception.StackTrace);

				MessageBox.Show(message.ToString(), "Character Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);

				Characters.Clear();
				listBoxCharacters.Items.Clear();
			}
		}

		private string FindCubeWorldDirectory()
		{
			const string cubeWorldSaveDirectory = @"\Cube World\Save";

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
	}
}
