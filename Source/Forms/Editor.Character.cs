using System;
using System.Windows.Forms;

namespace CharacterEditor.Forms
{
	public partial class Editor
	{
		// TODO Boss pets?

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
			object[][] specializations = new object[][]
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
	}
}
