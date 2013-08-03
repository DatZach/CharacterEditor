using System;
using System.Diagnostics;
using System.Windows.Forms;
using CharacterEditor.Forms;

namespace CharacterEditor
{
	public static class Program
	{
		public const string Version = "0.4c";

		[STAThread]
		public static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

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

			Application.Run(new Editor());
		}
	}
}
