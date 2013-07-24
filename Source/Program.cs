using System;
using System.Windows.Forms;
using CharacterEditor.Forms;
using System.Diagnostics;

namespace CharacterEditor
{
	static class Program
	{
		public const string Version = "0.3";

		[STAThread]
		public static void Main()
		{
#if !DEBUG
			AppDomain.CurrentDomain.UnhandledException += (sender, args) =>
			{
				Exception exception = (Exception)args.ExceptionObject;

				ExceptionDialog formException = new ExceptionDialog("An unrecoverable problem has occurred!", exception);
				formException.ShowDialog();

				if (args.IsTerminating)
					Application.Exit();
			};

			if (Process.GetProcessesByName("Cube").Length > 0)
            {
                MessageBox.Show("Please close Cube World before running the Character Editor.", "Character Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
#endif

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Editor());
		}
	}
}
