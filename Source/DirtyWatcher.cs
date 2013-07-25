using System.Windows.Forms;

namespace CharacterEditor
{
	class DirtyWatcher
	{
		public bool Dirty;
		public bool IgnoreDirtiness;

		public DirtyWatcher(Form form)
		{
			RecurseControls(form);
		}

		// Pleb tier recursion
		private void RecurseControls(Form form)
		{
			foreach (Control control in form.Controls)
				RecurseControlsInner(control);
		}

		private void RecurseControlsInner(Control parent)
		{
			foreach (Control control in parent.Controls)
			{
				if (control is TextBox)
				{
					control.TextChanged += (o, e) => Dirty = !IgnoreDirtiness || Dirty;
				}
				else if (control is ComboBox)
				{
					ComboBox comboBox = (ComboBox)control;
					comboBox.SelectedIndexChanged += (o, e) => Dirty = !IgnoreDirtiness || Dirty;
				}
				else if (control is NumericUpDown)
				{
					NumericUpDown numericUpDown = (NumericUpDown)control;
					numericUpDown.ValueChanged += (o, e) => Dirty = !IgnoreDirtiness || Dirty;
				}
				else if (control is CheckBox)
				{
					CheckBox checkBox = (CheckBox)control;
					checkBox.CheckedChanged += (o, e) => Dirty = !IgnoreDirtiness || Dirty;
				}
				else if (control is Button)
				{
					Button button = (Button)control;
					button.BackColorChanged += (o, e) => Dirty = !IgnoreDirtiness || Dirty;
				}

				RecurseControlsInner(control);
			}
		}
	}
}
