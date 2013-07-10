using System;
using System.Windows.Forms;

namespace CharacterEditor
{
    // TODO Don't allow the program to run with cube world

	public partial class FormEditor : Form
	{
		private readonly Database database;
		private CharacterData character;

		private static readonly int[,] faceMaximums = new[,]
		{
			{ 6, 6 },
			{ 4, 6 },
			{ 5, 5 },
			{ 5, 4 },
			{ 5, 6 },
			{ 2, 5 },
			{ 6, 6 },
			{ 5, 4 }
		};

		private static readonly int[,] haircutMaximums = new[,]
		{
			{ 15, 7 },
			{ 10, 10 },
			{ 3, 5 },
			{ 10, 4 },
			{ 6, 6 },
			{ 6, 6 },
			{ 6, 6 },
			{ 5, 4 }
		};

        private static readonly string[][] specializations = new[]
        {
            new[] { "Berserker", "Guardian" },
            new[] { "Sniper", "Scout" },
            new[] { "Fire Mage", "Water Mage" },
            new[] { "Assassin", "Ninja" }
        };

		public FormEditor()
		{
			database = new Database();
			InitializeComponent();
		}

		private void FormEditorShown(object sender, EventArgs e)
		{
            Text = "Character Editor v" + Program.Version;
            LoadCharacterDatabase();

            if (character == null)
            {
                Close();
                return;
            }

            Text += " [" + character.Name + "]";
		}

		private void SyncCharacterDataToGui()
		{
			textBoxName.Text = character.Name;
			nudLevel.Value = character.Level;
			nudExperience.Value = character.Experience;
			comboBoxGender.SelectedIndex = character.Gender;
			comboBoxRace.SelectedIndex = character.Race;
			comboBoxClass.SelectedIndex = character.Class - 1;
			nudFace.Value = character.Face;
			nudHair.Value = character.Hair;

			buttonHairColor.BackColor = Utility.FromAbgr(character.HairColor);

			comboBoxPetKind.SelectedIndex = CharacterData.PetKinds.IndexOf(character.PetIndex);
			if (comboBoxPetKind.SelectedIndex == -1)
				comboBoxPetKind.SelectedIndex = 0;

			if (character.PetLevel > 0)
				nudPetLevel.Value = character.PetLevel;

			nudPetExperience.Value = character.PetExperience;

            // TODO Find a cleaner way to do this, maybe?
            ComboBoxRaceSelectedIndexChanged(null, null);
            ComboBoxClassSelectedIndexChanged(null, null);
		}

		private void SyncGuiToCharacterData()
		{
			character.Name = textBoxName.Text;
			character.Level = (int)nudLevel.Value;
			character.Experience = (int)nudExperience.Value;
			character.Gender = (byte)comboBoxGender.SelectedIndex;
			character.Race = comboBoxRace.SelectedIndex;
			character.Class = (byte)(comboBoxClass.SelectedIndex + 1);
            character.Specialization = (byte)comboBoxSpecialization.SelectedIndex;
			character.Face = (int)nudFace.Value;
			character.Hair = (int)nudHair.Value;
			character.HairColor = Utility.ToAbgr(buttonHairColor.BackColor);
			character.PetIndex = (byte)comboBoxPetKind.SelectedIndex;
			character.PetLevel = (short)nudPetLevel.Value;
			character.PetExperience = (int)nudPetExperience.Value;
		}

		private void ButtonSaveCharacterClick(object sender, EventArgs e)
		{
			SyncGuiToCharacterData();
			MessageBox.Show(character.Save(database)
				                ? "Saved character to database successfully."
				                : "Something went wrong trying to save your character to the database.", "Character Editor",
			                MessageBoxButtons.OK);
		}

		private void ButtonHairColorClick(object sender, EventArgs e)
		{
			ColorDialog colorDialog = new ColorDialog
			{
				Color = buttonHairColor.BackColor,
				FullOpen = true
			};

			colorDialog.ShowDialog(this);

			buttonHairColor.BackColor = colorDialog.Color;
		}

		private void ComboBoxRaceSelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBoxRace.SelectedIndex == -1 || comboBoxGender.SelectedIndex == -1)
				return;

			nudFace.Maximum = faceMaximums[comboBoxRace.SelectedIndex, comboBoxGender.SelectedIndex];
			nudHair.Maximum = haircutMaximums[comboBoxRace.SelectedIndex, comboBoxGender.SelectedIndex];
		}

        private void ComboBoxClassSelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxClass.SelectedIndex == -1)
                return;

            comboBoxSpecialization.Items.Clear();
            comboBoxSpecialization.Items.AddRange(specializations[comboBoxClass.SelectedIndex]);

            comboBoxSpecialization.SelectedIndex = character.Specialization;
        }

		private void NudLevelValueChanged(object sender, EventArgs e)
		{
			nudPetLevel.Maximum = nudLevel.Value;
		}

        private void ButtonLoadNewCharacterClick(object sender, EventArgs e)
        {
            LoadCharacterDatabase();
            Text = "Character Editor v" + Program.Version + " [" + character.Name + "]";
        }

        private void LoadCharacterDatabase()
        {
            Enabled = false;

            FormLoadCharacter formLoadCharacter = new FormLoadCharacter(database)
            {
                StartPosition = FormStartPosition.CenterParent
            };

            DialogResult result = formLoadCharacter.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                character = formLoadCharacter.SelectedCharacter;

                SyncCharacterDataToGui();
            }

            Enabled = character != null;
        }
	}
}
