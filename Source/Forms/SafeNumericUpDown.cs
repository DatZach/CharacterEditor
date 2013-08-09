using System.Windows.Forms;

namespace CharacterEditor.Forms
{
	public class SafeNumericUpDown : NumericUpDown
	{
		public new decimal Value
		{
			get
			{
				return base.Value;
			}

			set
			{
				if (value < Minimum)
					base.Value = Minimum;
				else if (value > Maximum)
					base.Value = Maximum;
				else
					base.Value = value;
			}
		}
	}
}
