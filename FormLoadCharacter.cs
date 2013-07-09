using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CharacterEditor
{
	public partial class FormLoadCharacter : Form
	{
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

		private void ButtonLoadDatabaseClick(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog
			{
#if !DEBUG
				InitialDirectory = Utility.GetCubeWorldDirectory(),
#endif
				Filter = "Database|characters.db",
				CheckFileExists = true,
				CheckPathExists = true
			};

			DialogResult result = dialog.ShowDialog(this);
			if (result == DialogResult.Cancel)
				return;

			database.Load(dialog.FileName);
			Characters.Clear();
			listBoxCharacters.Items.Clear();

			int characterCount = database.ReadBlobByKey("num")[0];
			for(int i = 0; i < characterCount; ++i)
			{
				CharacterData character = new CharacterData(i);
				character.Load(database);

				Characters.Add(character);
				listBoxCharacters.Items.Add(character.Name);
			}
		}

		private void ListBoxCharactersSelectedIndexChanged(object sender, EventArgs e)
		{
			if (listBoxCharacters.SelectedIndex < 0 || listBoxCharacters.SelectedIndex >= Characters.Count)
				return;

			SelectedCharacter = Characters[listBoxCharacters.SelectedIndex];
			DialogResult = DialogResult.OK;
			Close();
		}
	}
}
