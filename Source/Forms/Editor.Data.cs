using System.Linq;
using System.Windows.Forms;
using CharacterEditor.Character;

namespace CharacterEditor.Forms
{
	public partial class Editor
	{
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

				foreach (Slot slot in inventory.Items)
				{
					ListViewItem listViewItem;

					if (slot.Count > 0 && slot.Item.Type != 0x00)
					{
						listViewItem = new ListViewItem
						{
							ImageIndex = slot.Item.Type,
							Text = slot.Item.FriendlyName,
							Tag = slot.Item
						};
					}
					else
					{
						listViewItem = new ListViewItem
						{
							ImageIndex = 0,
							Text = "",
							Tag = slot.Item
						};
					}

					listView.Items.Add(listViewItem);
				}

				tabPage.Controls.Add(listView);
				tabControlInventory.TabPages.Add(tabPage);
			}

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

			Item petEquipment = character.Equipment.Last();
			petEquipment.Type = (byte)(comboBoxPetKind.SelectedIndex <= 0 ? (int)Constants.ItemType.None : (int)Constants.ItemType.Pets);
			petEquipment.Subtype = (byte)Utility.GoofyIndex(comboBoxPetKind.SelectedIndex - 1, Constants.ItemSubtypes[(int)Constants.ItemType.Pets]);
			petEquipment.Level = (short)nudPetLevel.Value;
			// TODO Fix pets..........
			//petEquipment.Modifier = (short)nudPetExperience.Value;

			for (int i = 0; i < textBoxPetName.Text.Length; ++i)
				petEquipment.Attributes[i].Material = (byte)textBoxPetName.Text[i];

			dirtyWatcher.Dirty = false;
		}
	}
}
