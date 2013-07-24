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

		private void ComboBoxItemTypeSelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBoxItemType.SelectedIndex == -1)
				comboBoxItemType.SelectedIndex = 0;

			int subtypeIndex = Utility.GoofyIndex(comboBoxItemType.SelectedIndex, Constants.ItemTypeNames);

			comboBoxItemSubtype.Items.Clear();

			if (subtypeIndex <= 0)
				return;

			comboBoxItemSubtype.Items.AddRange(Constants.ItemSubtypes[subtypeIndex].Where(x => !String.IsNullOrEmpty(x)).ToArray());
			comboBoxItemSubtype.SelectedIndex = 0;
		}

		private void TabControlInventorySelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void ListViewInventorySelectedIndexChanged(object sender, EventArgs e)
		{
			if (SelectedItem == null)
				return;

			comboBoxItemType.SelectedIndex = Utility.NormalizeIndex(SelectedItem.Type, Constants.ItemTypeNames);
			comboBoxItemSubtype.SelectedIndex = SelectedItem.Type == 0
				? -1
				: Utility.NormalizeIndex(SelectedItem.Subtype, Constants.ItemSubtypes[SelectedItem.Type]);

			comboBoxItemMaterial.SelectedIndex = Utility.NormalizeIndex(SelectedItem.Material, Constants.ItemMaterialNames);
			comboBoxItemModifier.SelectedIndex = SelectedItem.Modifier & (Constants.ItemModifiers.Length - 1);
			if (comboBoxItemModifier.SelectedIndex != SelectedItem.Modifier)
				Console.WriteLine("Unknown modifier {0}!", SelectedItem.Modifier);

			nudItemLevel.Value = SelectedItem.Level;
			nudItemRarity.Value = SelectedItem.Rarity;
		}

		private void NudItemLevelValueChanged(object sender, EventArgs e)
		{
			if (SelectedItem == null)
				return;

			SelectedItem.Level = (short)nudItemLevel.Value;
		}

		private void ComboBoxItemMaterialSelectedIndexChanged(object sender, EventArgs e)
		{
			if (SelectedItem == null)
				return;

			SelectedItem.Material = (byte)Utility.GoofyIndex(comboBoxItemMaterial.SelectedIndex, Constants.ItemMaterialNames);
		}
	}
}
