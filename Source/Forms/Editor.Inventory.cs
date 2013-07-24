using System;
using System.Linq;
using System.Windows.Forms;
using CharacterEditor.Character;

namespace CharacterEditor.Forms
{
	public partial class Editor
	{
		// TODO Preserve dirty state when setting inventory controls to the right value

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

		private Inventory.Slot SelectedSlot
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

			if (comboBoxItemType.Items.Count == 0)
				comboBoxItemType.Items.AddRange(Constants.ItemTypeNames.Where(x => !String.IsNullOrEmpty(x)).ToArray());

			if (comboBoxItemMaterial.Items.Count == 0)
				comboBoxItemMaterial.Items.AddRange(Constants.ItemMaterialNames.Where(x => !String.IsNullOrEmpty(x)).ToArray());

			if (comboBoxItemModifier.Items.Count == 0)
			{
				string[] modifierList = (string[ ])Constants.ItemModifiers[0].Clone();
				modifierList[0] = "None";

				for (int i = 0; i < modifierList.Length; i++)
				{
					modifierList[i] = modifierList[i].Replace("{0}", null);
					modifierList[i] = modifierList[i].Replace("{1}", null);
				}

				comboBoxItemModifier.Items.Clear();
				comboBoxItemModifier.Items.AddRange(modifierList);
			}

			if (comboBoxItemRarity.Items.Count == 0)
				comboBoxItemRarity.Items.AddRange(new object[] { "Normal", "Uncommon", "Rare", "Epic", "Legendary" });

			comboBoxItemType.SelectedIndex = Utility.NormalizeIndex(SelectedItem.Type, Constants.ItemTypeNames);
			comboBoxItemSubtype.SelectedIndex = SelectedItem.Type == 0
				? -1
				: Utility.NormalizeIndex(SelectedItem.Subtype, Constants.ItemSubtypes[SelectedItem.Type]);

			comboBoxItemMaterial.SelectedIndex = Utility.NormalizeIndex(SelectedItem.Material, Constants.ItemMaterialNames);
			comboBoxItemModifier.SelectedIndex = SelectedItem.Modifier % Constants.ItemModifiers.Length;
			nudItemLevel.Value = SelectedItem.Level;
			comboBoxItemRarity.SelectedIndex = SelectedItem.Rarity;
			checkBoxItemAdapted.Checked = SelectedItem.Flags.HasFlag(Item.ItemFlags.Adapted);

			nudItemCount.Value = SelectedSlot.Count;
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

			SelectedItem.Modifier = (short)comboBoxItemModifier.SelectedIndex;
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
			if (SelectedItem == null)
				return;

			SelectedItem.Rarity = (byte)comboBoxItemRarity.SelectedIndex;

			string[] modifierList = (string[])Constants.ItemModifiers[SelectedItem.Rarity].Clone();
			modifierList[0] = "None";

			for (int i = 0; i < modifierList.Length; i++)
			{
				modifierList[i] = modifierList[i].Replace("{0}", null);
				modifierList[i] = modifierList[i].Replace("{1}", null);
			}

			int restoreIndex = comboBoxItemModifier.SelectedIndex;
			comboBoxItemModifier.Items.Clear();
			comboBoxItemModifier.Items.AddRange(modifierList);
			comboBoxItemModifier.SelectedIndex = restoreIndex;
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
			ListView listView = tabControlInventory.SelectedTab.Controls.OfType<ListView>().FirstOrDefault();
			if (listView == null || listView.SelectedItems.Count == 0)
				return;

			ListViewItem selectedItem = listView.SelectedItems[0];
			Item item = (Item)selectedItem.Tag;

			selectedItem.Text = item.FriendlyName;
			selectedItem.ImageIndex = item.Type;
		}
	}
}
