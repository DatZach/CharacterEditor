using System;
using System.Linq;
using System.Windows.Forms;
using CharacterEditor.Character;

namespace CharacterEditor.Forms
{
	public partial class Editor
	{
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

		private Slot SelectedSlot
		{
			get
			{
				Inventory inventory = character.Inventories[tabControlInventory.SelectedIndex];
				return inventory.Items.SingleOrDefault(t => t.Item == SelectedItem);
			}
		}

		// ListView Select
		private void ListViewInventorySelectedIndexChanged(object sender, EventArgs e)
		{
			if (SelectedItem == null)
				return;

			// Ignore dirtiness
			lock (dirtyWatcher)
				dirtyWatcher.IgnoreDirtiness = true;

			// Update controls if needed
			UpdateItemControls();

			if (SelectedSlot.Count != 0)
			{
				// There's an item here, update controls
				comboBoxItemType.SelectedIndex = Utility.NormalizeIndex(SelectedItem.Type, Constants.ItemTypeNames);
				comboBoxItemSubtype.SelectedIndex = Utility.NormalizeIndex(SelectedItem.Subtype, Constants.ItemSubtypes[SelectedItem.Type]);
				comboBoxItemMaterial.SelectedIndex = Utility.NormalizeIndex(SelectedItem.Material, Constants.ItemMaterialNames);
				//if (SelectedItem.Modifier != 0)
				//    comboBoxItemPrefixId.SelectedIndex = (SelectedItem.Modifier - 1) % 10 + 1;
				//else
				//    comboBoxItemPrefixId.SelectedIndex = 0;

				comboBoxItemPrefixId.SelectedIndex = SelectedItem.PrefixId;
				nudItemModelId.Value = SelectedItem.ModelId;
				nudItemEffectId.Value = SelectedItem.EffectId;

				nudItemHP.Value = (decimal)SelectedItem.Life;
				nudItemArmor.Value = (decimal)SelectedItem.Armor;
				nudItemResistance.Value = (decimal)SelectedItem.Resistance;
				nudItemTempo.Value = (decimal)SelectedItem.Tempo;
				nudItemCrit.Value = (decimal)SelectedItem.Critical;
				nudItemReg.Value = (decimal)SelectedItem.Regeneration;

				nudItemLevel.Value = SelectedItem.Level;
				comboBoxItemRarity.SelectedIndex = SelectedItem.Rarity;
				checkBoxItemAdapted.Checked = SelectedItem.Flags.HasFlag(Item.ItemFlags.Adapted);
				nudItemCount.Value = SelectedSlot.Count;
			}
			else
			{
				// No item here, update controls
				comboBoxItemType.SelectedIndex = -1;
				comboBoxItemSubtype.SelectedIndex = -1;
				comboBoxItemMaterial.SelectedIndex = -1;
				comboBoxItemPrefixId.SelectedIndex = -1;
				nudItemLevel.Value = 0;
				comboBoxItemRarity.SelectedIndex = -1;
				checkBoxItemAdapted.Checked = false;
				nudItemCount.Value = 0;
			}

			// Stop ignoring dirtiness
			lock (dirtyWatcher)
				dirtyWatcher.IgnoreDirtiness = false;
		}

		// Type
		private void ComboBoxItemTypeSelectedIndexChanged(object sender, EventArgs e)
		{
			if (SelectedItem == null)
				return;

			if (comboBoxItemType.SelectedIndex == -1)
				comboBoxItemType.SelectedIndex = 0;

			SelectedItem.Type = (byte)Utility.GoofyIndex(comboBoxItemType.SelectedIndex, Constants.ItemTypeNames);

			int subtypeIndex = Utility.GoofyIndex(comboBoxItemType.SelectedIndex, Constants.ItemTypeNames);

			comboBoxItemSubtype.Items.Clear();

			if (subtypeIndex <= 0)
				return;

			comboBoxItemSubtype.Items.AddRange(Constants.ItemSubtypes[subtypeIndex].Where(x => !String.IsNullOrEmpty(x)).ToArray());
			comboBoxItemSubtype.SelectedIndex = 0;

			UpdateItemAvatar();
		}

		// Subtype
		private void ComboBoxItemSubtypeSelectedIndexChanged(object sender, EventArgs e)
		{
			if (SelectedItem == null)
				return;

			SelectedItem.Subtype = (byte)Utility.GoofyIndex(comboBoxItemSubtype.SelectedIndex,
													  Constants.ItemSubtypes[SelectedItem.Type]);
			UpdateItemAvatar();
		}

		// Material
		private void ComboBoxItemMaterialSelectedIndexChanged(object sender, EventArgs e)
		{
			if (SelectedItem == null)
				return;

			SelectedItem.Material = (byte)Utility.GoofyIndex(comboBoxItemMaterial.SelectedIndex, Constants.ItemMaterialNames);
			UpdateItemAvatar();
		}

		// Modifer
		private void ComboBoxItemModifierSelectedIndexChanged(object sender, EventArgs e)
		{
			if (SelectedItem == null)
				return;

			// TODO Magic code right here
			//int offset = 0;
			//int offsetInitial = ((SelectedItem.ActualModifier - 1) % 10 + 1);
			//if (comboBoxItemPrefixId.SelectedIndex != 0)
			//    offset = comboBoxItemPrefixId.SelectedIndex - offsetInitial;

			//SelectedItem.Modifier = (short)(SelectedItem.ActualModifier + offset);
			UpdateItemAvatar();
		}

		// Level
		private void NudItemLevelValueChanged(object sender, EventArgs e)
		{
			if (SelectedItem == null)
				return;

			SelectedItem.Level = (short)nudItemLevel.Value;
			UpdateItemAvatar();
		}

		// Rarity
		private void ComboBoxItemRaritySelectedIndexChanged(object sender, EventArgs e)
		{
			if (SelectedItem == null || comboBoxItemRarity.SelectedIndex == -1)
				return;

			SelectedItem.Rarity = (byte)comboBoxItemRarity.SelectedIndex;

			string[] modifierList = (string[])Constants.ItemModifiers[SelectedItem.Rarity].Clone();

			for (int i = 0; i < modifierList.Length; i++)
			{
				modifierList[i] = modifierList[i].Replace("{0}", "*");
				modifierList[i] = modifierList[i].Replace("{1}", "*");
			}

			int restoreIndex = comboBoxItemPrefixId.SelectedIndex;
			comboBoxItemPrefixId.Items.Clear();
			comboBoxItemPrefixId.Items.Add("None");
			comboBoxItemPrefixId.Items.AddRange(modifierList);
			comboBoxItemPrefixId.SelectedIndex = restoreIndex;
		}

		// Adapted
		private void CheckBoxItemAdaptedCheckedChanged(object sender, EventArgs e)
		{
			if (SelectedItem == null)
				return;

			if (checkBoxItemAdapted.Checked)
				SelectedItem.Flags |= Item.ItemFlags.Adapted;
			else
				SelectedItem.Flags &= ~Item.ItemFlags.Adapted;
		}

		// Item Count
		private void NudItemCountValueChanged(object sender, EventArgs e)
		{
			if (SelectedSlot == null)
				return;

			SelectedSlot.Count = (int)nudItemCount.Value;
		}

		private void UpdateItemAvatar()
		{
			if (SelectedSlot.Count == 0)
				return;

			ListView listView = tabControlInventory.SelectedTab.Controls.OfType<ListView>().FirstOrDefault();
			if (listView == null || listView.SelectedItems.Count == 0)
				return;

			ListViewItem selectedItem = listView.SelectedItems[0];
			Item item = (Item)selectedItem.Tag;

			selectedItem.Text = item.FriendlyName;
			selectedItem.ImageIndex = item.Type;

			// TODO Might be somewhat out of place
			nudItemHP.Value = (decimal)SelectedItem.Life;
			nudItemArmor.Value = (decimal)SelectedItem.Armor;
			nudItemResistance.Value = (decimal)SelectedItem.Resistance;
			nudItemTempo.Value = (decimal)SelectedItem.Tempo;
			nudItemCrit.Value = (decimal)SelectedItem.Critical;
			nudItemReg.Value = (decimal)SelectedItem.Regeneration;
		}

		private void UpdateItemControls()
		{
			if (comboBoxItemType.Items.Count == 0)
				comboBoxItemType.Items.AddRange(Constants.ItemTypeNames.Where(x => !String.IsNullOrEmpty(x)).ToArray());

			if (comboBoxItemMaterial.Items.Count == 0)
				comboBoxItemMaterial.Items.AddRange(Constants.ItemMaterialNames.Where(x => !String.IsNullOrEmpty(x)).ToArray());

			if (comboBoxItemPrefixId.Items.Count == 0)
			{
				string[] modifierList = (string[])Constants.ItemModifiers[0].Clone();
				//modifierList[0] = "None";

				for (int i = 0; i < modifierList.Length; i++)
				{
					modifierList[i] = modifierList[i].Replace("{0}", null);
					modifierList[i] = modifierList[i].Replace("{1}", null);
				}

				comboBoxItemPrefixId.Items.Clear();
				comboBoxItemPrefixId.Items.Add("None");
				comboBoxItemPrefixId.Items.AddRange(modifierList);
			}

			if (comboBoxItemRarity.Items.Count == 0)
				comboBoxItemRarity.Items.AddRange(new object[] { "Normal", "Uncommon", "Rare", "Epic", "Legendary" });
		}
	}
}
