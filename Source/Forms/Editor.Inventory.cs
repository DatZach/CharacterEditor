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

		private bool canUpdateText;

		private void ComboBoxItemTypeSelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBoxItemType.SelectedIndex == -1)
				comboBoxItemType.SelectedIndex = 0;

			SelectedItem.Type = (byte)Utility.GoofyIndex(comboBoxItemType.SelectedIndex, Constants.ItemTypeNames);

			int subtypeIndex = Utility.GoofyIndex(comboBoxItemType.SelectedIndex, Constants.ItemTypeNames);

			comboBoxItemSubtype.Items.Clear();

			if (subtypeIndex <= 0)
				return;

			comboBoxItemSubtype.Items.AddRange(Constants.ItemSubtypes[subtypeIndex].Where(x => !String.IsNullOrEmpty(x)).ToArray());
			comboBoxItemSubtype.SelectedIndex = 0;

			string[] list = (string[])Constants.ItemModifiers[SelectedItem.Rarity].Clone();
			list[0] = "None";

			for (int i = 0; i < list.Length; i++)
			{
				list[i] = list[i].Replace("{0}", null);
				list[i] = list[i].Replace("{1}", null);
			}

			comboBoxItemModifier.Items.Clear();
			comboBoxItemModifier.Items.AddRange(list);

			UpdateItemText();
		}

		private void ComboBoxItemSubtypeSelectedIndexChanged(object sender, EventArgs e)
		{
			SelectedItem.Subtype = (byte)Utility.GoofyIndex(comboBoxItemSubtype.SelectedIndex,
													  Constants.ItemSubtypes[SelectedItem.Type]);
			UpdateItemText();
		}

		private void ListViewInventorySelectedIndexChanged(object sender, EventArgs e)
		{
			if (SelectedItem == null)
				return;

			canUpdateText = false;

			comboBoxItemType.SelectedIndex = Utility.NormalizeIndex(SelectedItem.Type, Constants.ItemTypeNames);
			comboBoxItemSubtype.SelectedIndex = SelectedItem.Type == 0
				? -1
				: Utility.NormalizeIndex(SelectedItem.Subtype, Constants.ItemSubtypes[SelectedItem.Type]);

			comboBoxItemMaterial.SelectedIndex = Utility.NormalizeIndex(SelectedItem.Material, Constants.ItemMaterialNames);
			comboBoxItemModifier.SelectedIndex = SelectedItem.Modifier % Constants.ItemModifiers.Length;
			nudItemLevel.Value = SelectedItem.Level;
			nudItemRarity.Value = SelectedItem.Rarity;

			canUpdateText = true;
		}

		private void NudItemLevelValueChanged(object sender, EventArgs e)
		{
			if (SelectedItem == null)
				return;

			SelectedItem.Level = (short)nudItemLevel.Value;
			UpdateItemText();
		}

		private void ComboBoxItemMaterialSelectedIndexChanged(object sender, EventArgs e)
		{
			if (SelectedItem == null)
				return;

			SelectedItem.Material = (byte)Utility.GoofyIndex(comboBoxItemMaterial.SelectedIndex, Constants.ItemMaterialNames);
			UpdateItemText();
		}

		private void UpdateItemText()
		{
			if (!canUpdateText)
				return;

			ListView listView = tabControlInventory.SelectedTab.Controls.OfType<ListView>().FirstOrDefault();
			if (listView == null || listView.SelectedItems.Count == 0)
				return;

			ListViewItem item = listView.SelectedItems[0];
			item.Text = ((Item)item.Tag).FriendlyName;
		}
	}
}
