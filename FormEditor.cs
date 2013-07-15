using System;
using System.Threading;
using System.Windows.Forms;

namespace CharacterEditor
{
	// TODO Coins
	// TODO Add character delete and add?
	// TODO Add character.db merging?

	public partial class FormEditor : Form
	{
		private readonly Database database;
		private CharacterData character;
		private DirtyWatcher dirtyWatcher;
		private Thread dirtyThread;

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

			dirtyWatcher = new DirtyWatcher(this);
			dirtyThread = new Thread(obj =>
			{
				bool previousDirty = !dirtyWatcher.Dirty;

				while (!IsDisposed)
				{
					if (dirtyWatcher.Dirty != previousDirty)
					{
						string title = "Character Editor v" + Program.Version + " [" + character.Name + "]";

						if (dirtyWatcher.Dirty)
							title += " *";

						if (InvokeRequired)
							Invoke(new MethodInvoker(() => Text = title));
						else
							Text = title;

						previousDirty = dirtyWatcher.Dirty;
					}

					Thread.Sleep(1);
				}
			});

			dirtyThread.Start();
		}

		private void ButtonSaveCharacterClick(object sender, EventArgs e)
		{
			SyncGuiToCharacterData();

			if (!character.Save(database))
				MessageBox.Show(this, "Something went wrong trying to save your character to the database.", "Character Editor",
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
			int[,] faceMaximums = new[,]
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

			int[,] haircutMaximums = new[,]
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

			if (comboBoxRace.SelectedIndex == -1 || comboBoxGender.SelectedIndex == -1)
				return;

			nudFace.Maximum = faceMaximums[comboBoxRace.SelectedIndex, comboBoxGender.SelectedIndex];
			nudHair.Maximum = haircutMaximums[comboBoxRace.SelectedIndex, comboBoxGender.SelectedIndex];
		}

		private void ComboBoxClassSelectedIndexChanged(object sender, EventArgs e)
		{
			string[][] specializations = new[]
			{
				new[] { "Berserker", "Guardian" },
				new[] { "Sniper", "Scout" },
				new[] { "Fire Mage", "Water Mage" },
				new[] { "Assassin", "Ninja" }
			};

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
			if (dirtyWatcher.Dirty)
			{
				DialogResult result = MessageBox.Show(this, "Would you like to save changes before loading a new character?", "Character Editor",
											MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
				switch (result)
				{
					case DialogResult.Yes:
						SyncGuiToCharacterData();
						character.Save(database);
						break;

					case DialogResult.No:
						break;

					case DialogResult.Cancel:
						return;
				}
			}

			LoadCharacterDatabase();
		}

		private void SyncCharacterDataToGui()
		{
			textBoxName.Text = character.Name;
			nudLevel.Value = character.Level;
			nudExperience.Value = character.Experience;
			comboBoxGender.SelectedIndex = character.Gender;
			comboBoxRace.SelectedIndex = character.Race;
			comboBoxClass.SelectedIndex = (int)character.Class - 1;
			nudFace.Value = character.Face;
			nudHair.Value = character.Hair;

			buttonHairColor.BackColor = character.HairColor;

			/*comboBoxPetKind.SelectedIndex = CharacterData.PetKinds.IndexOf(character.PetIndex);
			if (comboBoxPetKind.SelectedIndex == -1)
				comboBoxPetKind.SelectedIndex = 0;

			if (character.PetLevel > 0)
				nudPetLevel.Value = character.PetLevel;

			nudPetExperience.Value = character.PetExperience;*/

			// TODO Find a cleaner way to do this, maybe?
			ComboBoxRaceSelectedIndexChanged(null, null);
			ComboBoxClassSelectedIndexChanged(null, null);

			if (dirtyWatcher != null)
				dirtyWatcher.Dirty = false;
		}

		private void SyncGuiToCharacterData()
		{
			character.Name = textBoxName.Text;
			character.Level = (int)nudLevel.Value;
			character.Experience = (int)nudExperience.Value;
			character.Gender = (byte)comboBoxGender.SelectedIndex;
			character.Race = comboBoxRace.SelectedIndex;
			character.Class = (CharacterData.ClassType)(comboBoxClass.SelectedIndex + 1);
			character.Specialization = (byte)comboBoxSpecialization.SelectedIndex;
			character.Face = (int)nudFace.Value;
			character.Hair = (int)nudHair.Value;
			character.HairColor = buttonHairColor.BackColor;
			/*character.PetIndex = (byte)comboBoxPetKind.SelectedIndex;
			character.PetLevel = (short)nudPetLevel.Value;
			character.PetExperience = (int)nudPetExperience.Value;*/

			dirtyWatcher.Dirty = false;
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

		private void FormEditorClosing(object sender, FormClosingEventArgs e)
		{
			if (dirtyWatcher == null || !dirtyWatcher.Dirty)
				return;

			DialogResult result = MessageBox.Show(this, "Would you like to save changes before closing?", "Character Editor",
												  MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
			switch (result)
			{
				case DialogResult.Yes:
					SyncGuiToCharacterData();
					character.Save(database);
					break;

				case DialogResult.No:
					break;

				case DialogResult.Cancel:
					e.Cancel = true;
					return;
			}

			dirtyThread.Abort();
		}
	}
}
