using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using CharacterEditor.Character;

namespace CharacterEditor.Forms
{
	public partial class Editor : Form
	{
		private readonly Database database;
		private Character.Character character;
		private DirtyWatcher dirtyWatcher;
		private Thread dirtyThread;

		public Editor()
		{
			database = new Database();

			InitializeComponent();

			labelAboutEditorName.Text += " v" + Program.Version;

			comboBoxPetKind.Items.Add("None");
			string[] pets = Constants.ItemSubtypes[(int)Constants.ItemType.Pets];
			comboBoxPetKind.Items.AddRange(pets.Where(x => !String.IsNullOrEmpty(x)).ToArray());
		}

		private void FormEditorShown(object sender, EventArgs e)
		{
			Text = "Character Editor v" + Program.Version;
			LoadCharacterDatabase();

			if (character == null)
			{
				Close();
				return;
			}

			dirtyWatcher = new DirtyWatcher(this);
			dirtyThread = new Thread(obj =>
			{
				bool previousDirty = !dirtyWatcher.Dirty;

				while (!IsDisposed)
				{
					lock (dirtyWatcher)
					{
						if (dirtyWatcher.Dirty != previousDirty && !dirtyWatcher.IgnoreDirtiness)
						{
							string title = "Character Editor v" + Program.Version + " [" + character.Name + "]";

							if (dirtyWatcher.Dirty)
								title += " *";

							if (InvokeRequired)
								Invoke(new MethodInvoker(() => Text = title));
							else
								Text = title;

							previousDirty = dirtyWatcher.Dirty;
						}
						else if (dirtyWatcher.IgnoreDirtiness)
							dirtyWatcher.Dirty = false;
					}

					Thread.Sleep(1);
				}
			});

			dirtyThread.Start();
		}

		private void FormEditorClosing(object sender, FormClosingEventArgs e)
		{
			if (dirtyWatcher == null || !dirtyWatcher.Dirty)
				return;

			DialogResult result = MessageBox.Show(this, "Would you like to save changes before closing?", "Character Editor",
												  MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
			switch (result)
			{
				case DialogResult.Yes:
					SyncGuiToCharacterData();
					character.Save(database);
					break;

				case DialogResult.No:
					break;

				case DialogResult.Cancel:
					e.Cancel = true;
					return;
			}

			dirtyThread.Abort();
		}

		private void ButtonSaveCharacterClick(object sender, EventArgs e)
		{
			SyncGuiToCharacterData();

			if (!character.Save(database))
				MessageBox.Show(this, "Something went wrong trying to save your character to the database.", "Character Editor",
								MessageBoxButtons.OK);
		}

		private void ButtonLoadNewCharacterClick(object sender, EventArgs e)
		{
			if (dirtyWatcher.Dirty)
			{
				DialogResult result = MessageBox.Show(this, "Would you like to save changes before loading a new character?", "Character Editor",
											MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
				switch (result)
				{
					case DialogResult.Yes:
						SyncGuiToCharacterData();
						character.Save(database);
						break;

					case DialogResult.No:
						break;

					case DialogResult.Cancel:
						return;
				}
			}

			LoadCharacterDatabase();
		}

		private void LoadCharacterDatabase()
		{
			Enabled = false;

			LoadCharacter loadCharacter = new LoadCharacter(database)
			{
				StartPosition = FormStartPosition.CenterParent
			};

			DialogResult result = loadCharacter.ShowDialog(this);

			if (result == DialogResult.OK)
			{
				character = loadCharacter.SelectedCharacter;

				SyncCharacterDataToGui();
			}

			Enabled = character != null;
		}

		private void LinkLabelX2048LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("http://www.x2048.com/");
		}
	}
}
