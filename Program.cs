using System;
using System.Windows.Forms;

namespace CharacterEditor
{
	static class Program
	{
		public const string Version = "0.2";

		[STAThread]
		public static void Main()
		{
#if !DEBUG
			AppDomain.CurrentDomain.UnhandledException += (sender, args) =>
			{
				Exception exception = (Exception)args.ExceptionObject;

				StringBuilder message = new StringBuilder();
				if (args.IsTerminating)
				{
					message.AppendLine("An unrecoverable problem occurred!");
					message.AppendLine("Please report the information below to the developer.");
				}
				else
				{
					message.AppendLine("Something went wrong!");
					message.AppendLine(
					                   "You can try and Retry to continue running, this may result in instability and may corrupt your data.");
					message.AppendLine("Or you can click Cancel and report the technical information to the developer.");
				}

				message.AppendLine(exception.Message);
				message.AppendLine(exception.Source);
				message.AppendLine(exception.StackTrace);

				if (args.IsTerminating)
				{
					MessageBox.Show(message.ToString(), "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					Application.Exit();
				}
				else
				{
					DialogResult result = MessageBox.Show(message.ToString(), "Oops!", MessageBoxButtons.RetryCancel,
					                                      MessageBoxIcon.Error);
					if (result == DialogResult.Cancel)
						Application.Exit();
				}
			};
#endif

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FormEditor());
		}
	}
}
