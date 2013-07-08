using System;
using System.Windows.Forms;

namespace CharacterEditor
{
	public partial class FormEditor : Form
	{
		private readonly Database database;
		private CharacterData character;

		public FormEditor()
		{
			database = new Database();
			InitializeComponent();
		}

		private void FormEditorShown(object sender, EventArgs e)
		{
			Enabled = false;

			FormLoadCharacter formLoadCharacter = new FormLoadCharacter(database)
			{
				StartPosition = FormStartPosition.CenterParent
			};

			DialogResult result = formLoadCharacter.ShowDialog(this);

			if (result == DialogResult.OK)
			{
				Enabled = true;
				character = formLoadCharacter.SelectedCharacter;

				SyncCharacterDataToGui();
			}
			else
				Close();
		}

		private void SyncCharacterDataToGui()
		{
			textBoxName.Text = character.Name;
			nudLevel.Value = character.Level;
			nudExperience.Value = character.Experience;
			comboBoxGender.SelectedIndex = character.Gender;
			comboBoxRace.SelectedIndex = character.Race;
			nudFace.Value = character.Face;
			nudHair.Value = character.Hair;
		}

		private void SyncGuiToCharacterData()
		{
			character.Name = textBoxName.Text;
			character.Level = (int)nudLevel.Value;
			character.Experience = (int)nudExperience.Value;
			character.Gender = (byte)comboBoxGender.SelectedIndex;
			character.Race = comboBoxRace.SelectedIndex;
			character.Face = (int)nudFace.Value;
			character.Hair = (int)nudHair.Value;
		}

		private void ButtonSaveCharacterClick(object sender, EventArgs e)
		{
			SyncGuiToCharacterData();
			MessageBox.Show(
			                character.Save(database)
				                ? "Saved character to database successfully."
				                : "Something went wrong trying to save your character to the database.", "Character Editor",
			                MessageBoxButtons.OK);
		}
	}
}
