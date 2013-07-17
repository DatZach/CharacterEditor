using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using CharacterEditor.Character;

namespace CharacterEditor.Forms
{
	public partial class Editor : Form
	{
		private readonly Database database;
		private Character.Character character;
		private DirtyWatcher dirtyWatcher;
		private Thread dirtyThread;

		private Item SelectedItem
		{
			get
			{
				ListView listView = tabControlInventory.SelectedTab.Controls.OfType<ListView>().FirstOrDefault();
				if (listView == null || listView.SelectedItems.Count == 0)
					return null;

				return (Item)listView.SelectedItems[0].Tag;
			}
		}

		public Editor()
		{
			database = new Database();

			InitializeComponent();

			comboBoxPetKind.Items.Add("None");
			comboBoxPetKind.Items.AddRange(Constants.ItemSubtypes[(int)Constants.ItemType.Pets].Where(x => !String.IsNullOrEmpty(x)).ToArray());
			comboBoxItemType.Items.AddRange(Constants.ItemTypeNames.Where(x => !String.IsNullOrEmpty(x)).ToArray());
			comboBoxItemMaterial.Items.AddRange(Constants.ItemMaterialNames.Where(x => !String.IsNullOrEmpty(x)).ToArray());
			comboBoxItemModifier.Items.AddRange(Constants.ItemModifiers.Where(x => !String.IsNullOrEmpty(x)).ToArray());
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

		private void ButtonSaveCharacterClick(object sender, EventArgs e)
		{
			SyncGuiToCharacterData();

			if (!character.Save(database))
				MessageBox.Show(this, "Something went wrong trying to save your character to the database.", "Character Editor",
								MessageBoxButtons.OK);
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

			for (int i = 0; i < Character.Character.EquipmentCount; ++i)
			{
				Item item = character.Equipment[i];

				// Do not add unused and pet equipment
				if (i == 0 || i == 12)
					continue;

				TabPage tabPage = CreateEquipmentTab(i);
				tabPage.Tag = item;

				tabControlEquipment.TabPages.Add(tabPage);
			}

			Item petEquipment = character.Equipment.Last();
			comboBoxPetKind.SelectedIndex = Utility.NormalizeIndex(petEquipment.Subtype, Constants.ItemSubtypes[(int)Constants.ItemType.Pets]) + 1;
			if (comboBoxPetKind.SelectedIndex == -1)
				comboBoxPetKind.SelectedIndex = 0;

			nudPetLevel.Value = petEquipment.Level;
			nudPetExperience.Value = petEquipment.Modifier;
			textBoxPetName.Text = petEquipment.Attributes.Aggregate("", (c, a) => c + (char)a.Material);

			nudCoinsGold.Value = (character.Coins / 10000) % 100;
			nudCoinsSilver.Value = (character.Coins / 100) % 100;
			nudCoinsCopper.Value = character.Coins % 100;
			nudCoinsPlatinum.Value = character.PlatinumCoins;

			// Sync inventory to GUI
			for (int i = 0; i < Character.Character.InventoryCount; ++i)
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
			// TODO Shouldn't I be able to link all this with a DataModel?

			character.Name = textBoxName.Text;
			character.Level = (int)nudLevel.Value;
			character.Experience = (int)nudExperience.Value;
			character.Gender = (byte)comboBoxGender.SelectedIndex;
			character.Race = comboBoxRace.SelectedIndex;
			character.Class = (Character.Character.ClassType)(comboBoxClass.SelectedIndex + 1);
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

			character.Coins = (int)(nudCoinsGold.Value * 10000 + nudCoinsSilver.Value * 100 + nudCoinsCopper.Value);
			character.PlatinumCoins = (int)nudCoinsPlatinum.Value;

			// TODO No, just no
			Item petEquipment = character.Equipment.Last();
			petEquipment.Type = (byte)(comboBoxPetKind.SelectedIndex <= 0 ? (int)Constants.ItemType.None : (int)Constants.ItemType.Pets);
			petEquipment.Subtype = (byte)Utility.GoofyIndex(comboBoxPetKind.SelectedIndex - 1, Constants.ItemSubtypes[(int)Constants.ItemType.Pets]);
			petEquipment.Level = (short)nudPetLevel.Value;
			petEquipment.Modifier = (short)nudPetExperience.Value;

			for (int i = 0; i < textBoxPetName.Text.Length; ++i)
				petEquipment.Attributes[i].Material = (byte)textBoxPetName.Text[i];

			dirtyWatcher.Dirty = false;
		}

		private void LoadCharacterDatabase()
		{
			Enabled = false;

			LoadCharacter loadCharacter = new LoadCharacter(database)
			{
				StartPosition = FormStartPosition.CenterParent
			};

			DialogResult result = loadCharacter.ShowDialog(this);

			if (result == DialogResult.OK)
			{
				character = loadCharacter.SelectedCharacter;

				SyncCharacterDataToGui();
			}

			Enabled = character != null;
		}
	}
}
