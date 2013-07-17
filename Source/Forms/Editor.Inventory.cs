using System;
using System.Linq;
using CharacterEditor.Character;

namespace CharacterEditor.Forms
{
	public partial class Editor
	{
		private void ComboBoxItemTypeSelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBoxItemType.SelectedIndex == -1)
				comboBoxItemType.SelectedIndex = 0;

			int subtypeIndex = Utility.GoofyIndex(comboBoxItemType.SelectedIndex, Constants.ItemTypeNames);

			comboBoxItemSubtype.Items.Clear();

			if (subtypeIndex > 0)
			{
				comboBoxItemSubtype.Items.AddRange(Constants.ItemSubtypes[subtypeIndex].Where(x => !String.IsNullOrEmpty(x)).ToArray());
				comboBoxItemSubtype.SelectedIndex = 0;
			}
		}

		private void TabControlInventorySelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void ListViewInventorySelectedIndexChanged(object sender, EventArgs e)
		{
			if (SelectedItem == null)
				return;

			comboBoxItemType.SelectedIndex = Utility.NormalizeIndex(SelectedItem.Type, Constants.ItemTypeNames);
			comboBoxItemSubtype.SelectedIndex = SelectedItem.Type == 0 ? -1 : Utility.NormalizeIndex(SelectedItem.Subtype,
																						Constants.ItemSubtypes[SelectedItem.Type]);
			comboBoxItemMaterial.SelectedIndex = Utility.NormalizeIndex(SelectedItem.Material, Constants.ItemMaterialNames);
			comboBoxItemModifier.SelectedIndex = SelectedItem.Modifier & Constants.ItemModifiers.Length;
			nudItemLevel.Value = SelectedItem.Level;
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
