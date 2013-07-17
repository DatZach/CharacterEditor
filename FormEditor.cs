using System;
using System.Linq;
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

			comboBoxPetKind.Items.Add("None");
			comboBoxPetKind.Items.AddRange(Item.Subtypes[0x13].Where(x => !String.IsNullOrEmpty(x)).ToArray());
			comboBoxItemType.Items.AddRange(Item.TypeNames.Where(x => !String.IsNullOrEmpty(x)).ToArray());
			comboBoxItemMaterial.Items.AddRange(Item.MaterialNames.Where(x => !String.IsNullOrEmpty(x)).ToArray());

			// Unit testing
			for(int i = 0; i < Item.TypeNames.Length; ++i)
			{

				Console.WriteLine("Type = {0}; Subtype = {1}", i, Utility.GoofyIndex(i, Item.TypeNames));
			}
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

			nudPetMasterSkillLevel.Value = character.PetMasterSkillLevel;
			nudPetRidingSkillLevel.Value = character.PetRidingSkillLevel;
			nudClimbingSkillLevel.Value = character.ClimbingSkillLevel;
			nudHangGlidingSkillLevel.Value = character.HangGlidingSkillLevel;
			nudSwimmingSkillLevel.Value = character.SwimmingSkillLevel;
			nudSailingSkillLevel.Value = character.SailingSkillLevel;
			nudTierOneSkillLevel.Value = character.TierOneSkillLevel;
			nudTierTwoSkillLevel.Value = character.TierTwoSkillLevel;
			nudTierThreeSkillLevel.Value = character.TierThreeSkillLevel;

			Item petEquipment = character.Equipment.Last();
			comboBoxPetKind.SelectedIndex = CharacterData.PetKinds.IndexOf(petEquipment.Subtype);
			if (comboBoxPetKind.SelectedIndex == -1)
				comboBoxPetKind.SelectedIndex = 0;

			nudPetLevel.Value = petEquipment.Level;
			nudPetExperience.Value = petEquipment.Modifier;
			textBoxPetName.Text = petEquipment.Attributes.Aggregate("", (c, a) => c + (char)a.Material);

			// Sync inventory to GUI
			for (int i = 0; i < CharacterData.InventoryCount; ++i)
			{
				Inventory inventory = character.Inventories[i];

				TabPage tabPage = new TabPage(new[] { "Equipment", "Items", "Ingredients", "Pets" }[i]);
				ListView listView = new ListView
				{
					Activation = ItemActivation.OneClick,
					BorderStyle = BorderStyle.None,
					Dock = DockStyle.Fill,
					HideSelection = false,
					LargeImageList = imageListInventory,
					MultiSelect = false,
					UseCompatibleStateImageBehavior = false
				};

				// Ok .NET 2.0, have it your way
				listView.SelectedIndexChanged += ListViewInventorySelectedIndexChanged;

				foreach (Tuple<int, Item> item in inventory.Items)
				{
					ListViewItem listViewItem;

					if (item.Item1 > 0 && item.Item2.Type != 0x00)
					{
						listViewItem = new ListViewItem
						{
							ImageIndex = item.Item2.Type,
							Text = item.Item2.FriendlyName,
							Tag = item.Item2
						};
					}
					else
					{
						listViewItem = new ListViewItem
						{
							ImageIndex = 0,
							Text = "",
							Tag = item.Item2
						};
					}

					listView.Items.Add(listViewItem);
				}

				tabPage.Controls.Add(listView);
				tabControlInventory.TabPages.Add(tabPage);
			}

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

			character.PetMasterSkillLevel = (int)nudPetMasterSkillLevel.Value;
			character.PetRidingSkillLevel = (int)nudPetRidingSkillLevel.Value;
			character.ClimbingSkillLevel = (int)nudClimbingSkillLevel.Value;
			character.HangGlidingSkillLevel = (int)nudHangGlidingSkillLevel.Value;
			character.SwimmingSkillLevel = (int)nudSwimmingSkillLevel.Value;
			character.SailingSkillLevel = (int)nudSailingSkillLevel.Value;
			character.TierOneSkillLevel = (int)nudTierOneSkillLevel.Value;
			character.TierTwoSkillLevel = (int)nudTierTwoSkillLevel.Value;
			character.TierThreeSkillLevel = (int)nudTierThreeSkillLevel.Value;

			// TODO No, just no
			Item petEquipment = character.Equipment.Last();
			petEquipment.Type = (byte)(comboBoxPetKind.SelectedIndex <= 0 ? 0x00 : 0x13);
			petEquipment.Subtype = (byte)(Utility.GoofyIndex(comboBoxPetKind.SelectedIndex, Item.Subtypes[0x13]) - 1);
			petEquipment.Level = (short)nudPetLevel.Value;
			petEquipment.Modifier = (short)nudPetExperience.Value;

			for (int i = 0; i < textBoxPetName.Text.Length; ++i)
				petEquipment.Attributes[i].Material = (byte)textBoxPetName.Text[i];

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

		private void ComboBoxItemTypeSelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBoxItemType.SelectedIndex == -1)
				comboBoxItemType.SelectedIndex = 0;

			// Type is normalized now, Subtypes is not normalized

			int subtypeIndex = Utility.GoofyIndex(comboBoxItemType.SelectedIndex, Item.TypeNames);

			comboBoxItemSubtype.Items.Clear();
			comboBoxItemSubtype.Items.AddRange(Item.Subtypes[subtypeIndex].Where(x => !String.IsNullOrEmpty(x)).ToArray());
			comboBoxItemSubtype.SelectedIndex = 0;
		}

		private void TabControlInventorySelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void ListViewInventorySelectedIndexChanged(object sender, EventArgs e)
		{
			// TODO Unsafish
			ListView listView = (ListView)tabControlInventory.SelectedTab.Controls[0];
			if (listView.SelectedItems.Count == 0)
				return;

			ListViewItem selectedItem = listView.SelectedItems[0];
			Item item = (Item)selectedItem.Tag;

			// TODO Indices don't match up with combobox because of missing/null entries in game
			comboBoxItemType.SelectedIndex = Utility.NormalizeIndex(item.Type, Item.TypeNames);
			comboBoxItemSubtype.SelectedIndex = Utility.NormalizeIndex(item.Subtype, Item.Subtypes[item.Type]);
			comboBoxItemMaterial.SelectedIndex = Utility.NormalizeIndex(item.Material, Item.MaterialNames);
			//comboBoxItemModifier.SelectedIndex = item.Modifier & 0x0F;
			nudItemLevel.Value = item.Level;
		}
	}
}
