using System;
using System.Text;
using System.Windows.Forms;

namespace CharacterEditor.Forms
{
	public partial class ExceptionDialog : Form
	{
		public ExceptionDialog(string humanMessage, Exception exception)
		{
			InitializeComponent();

			labelExceptionMessage.Text = humanMessage;

			StringBuilder message = new StringBuilder();

			message.AppendLine(exception.Message);
			message.AppendLine();
			message.AppendLine(exception.Source);
			message.AppendLine(exception.StackTrace);

			textBoxExceptionInformation.Text = message.ToString();
		}

		private void ButtonCloseClick(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void ButtonCopyToClipboardClick(object sender, EventArgs e)
		{
			Clipboard.SetText(textBoxExceptionInformation.Text);
		}

		private void ButtonContinueClick(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			Close();
		}

		private void FormExceptionClosed(object sender, FormClosedEventArgs e)
		{
			if (DialogResult != DialogResult.OK)
				Application.Exit();
		}
	}
}
