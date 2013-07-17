using System;
using System.Linq;
using System.Windows.Forms;
using CharacterEditor.Character;

namespace CharacterEditor.Forms
{
	public partial class Editor
	{
		private TabPage CreateEquipmentTab(int i)
		{
			TabPage tabPage =
				new TabPage(
					new[]
					{
						"", "Neck", "Chest", "Feet", "Hands", "Shoulder Armor", "Left Weapon", "Right Weapon", "Left Ring", "Right Ring",
						"Light", "Special", "Pet"
					}[i]);

			ComboBox comboBoxEquipmentItemMaterial = new ComboBox
			{
				DropDownStyle = ComboBoxStyle.DropDownList,
				Location = new System.Drawing.Point(266, 32),
				Size = new System.Drawing.Size(124, 21)
			};

			Label labelEquipmentItemMaterial = new Label
			{
				AutoSize = true,
				Location = new System.Drawing.Point(267, 16),
				Size = new System.Drawing.Size(47, 13),
				Text = "Material:"
			};

			NumericUpDown nudEquipmentItemLevel = new NumericUpDown
			{
				Location = new System.Drawing.Point(136, 77),
				Maximum = 0x7FFF,
				Size = new System.Drawing.Size(124, 20)
			};

			Label labelEquipmentItemLevel = new Label
			{
				AutoSize = true,
				Location = new System.Drawing.Point(133, 60),
				Size = new System.Drawing.Size(36, 13),
				Text = "Level:"
			};

			ComboBox comboBoxEquipmentItemModifier = new ComboBox
			{
				DropDownStyle = ComboBoxStyle.DropDownList,
				Location = new System.Drawing.Point(136, 32),
				Size = new System.Drawing.Size(124, 21),
			};

			comboBoxEquipmentItemModifier.Items.AddRange(Constants.ItemModifiers.Where(x => !String.IsNullOrEmpty(x)).ToArray());

			Label labelEquipmentItemModifier = new Label
			{
				AutoSize = true,
				Location = new System.Drawing.Point(133, 16),
				Size = new System.Drawing.Size(47, 13),
				Text = "Modifier:"
			};

			Label labelEquipmentItemSubtype = new Label
			{
				AutoSize = true,
				Location = new System.Drawing.Point(7, 60),
				Size = new System.Drawing.Size(49, 13),
				Text = "Subtype:"
			};

			Label labelEquipmentItemType = new Label
			{
				AutoSize = true,
				Location = new System.Drawing.Point(6, 16),
				Size = new System.Drawing.Size(34, 13),
				Text = "Type:"
			};

			ComboBox comboBoxEquipmentItemSubtype = new ComboBox
			{
				DropDownStyle = ComboBoxStyle.DropDownList,
				Location = new System.Drawing.Point(6, 76),
				Size = new System.Drawing.Size(124, 21)
			};

			ComboBox comboBoxEquipmentItemType = new ComboBox
			{
				DropDownStyle = ComboBoxStyle.DropDownList,
				Location = new System.Drawing.Point(6, 32),
				Size = new System.Drawing.Size(124, 21)
			};

			GroupBox groupBoxEquipmentItem = new GroupBox
			{
				Enabled = false,
				Location = new System.Drawing.Point(6, 6),
				Size = new System.Drawing.Size(522, 189),
				TabStop = false,
				Text = "Item"
			};

			groupBoxEquipmentItem.Controls.AddRange(new Control[]
			{
				comboBoxEquipmentItemMaterial,
				labelEquipmentItemMaterial,
				nudEquipmentItemLevel,
				labelEquipmentItemLevel,
				comboBoxEquipmentItemModifier,
				labelEquipmentItemModifier,
				labelEquipmentItemSubtype,
				labelEquipmentItemType,
				comboBoxEquipmentItemSubtype,
				comboBoxEquipmentItemType
			});

			tabPage.Controls.Add(groupBoxEquipmentItem);

			return tabPage;
		}
	}
}
