namespace CharacterEditor.Forms
{
	partial class LoadCharacterDialog
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadCharacterDialog));
			this.buttonLoadDatabase = new System.Windows.Forms.Button();
			this.listBoxCharacters = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// buttonLoadDatabase
			// 
			this.buttonLoadDatabase.Location = new System.Drawing.Point(361, 247);
			this.buttonLoadDatabase.Name = "buttonLoadDatabase";
			this.buttonLoadDatabase.Size = new System.Drawing.Size(101, 23);
			this.buttonLoadDatabase.TabIndex = 1;
			this.buttonLoadDatabase.Text = "Load Database";
			this.buttonLoadDatabase.UseVisualStyleBackColor = true;
			this.buttonLoadDatabase.Click += new System.EventHandler(this.ButtonLoadDatabaseClick);
			// 
			// listBoxCharacters
			// 
			this.listBoxCharacters.FormattingEnabled = true;
			this.listBoxCharacters.Location = new System.Drawing.Point(12, 12);
			this.listBoxCharacters.Name = "listBoxCharacters";
			this.listBoxCharacters.ScrollAlwaysVisible = true;
			this.listBoxCharacters.Size = new System.Drawing.Size(450, 225);
			this.listBoxCharacters.TabIndex = 0;
			this.listBoxCharacters.SelectedIndexChanged += new System.EventHandler(this.ListBoxCharactersSelectedIndexChanged);
			// 
			// LoadCharacterDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(474, 282);
			this.Controls.Add(this.listBoxCharacters);
			this.Controls.Add(this.buttonLoadDatabase);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LoadCharacterDialog";
			this.ShowInTaskbar = false;
			this.Text = "Load a Character";
			this.Load += new System.EventHandler(this.FormLoadCharacterLoad);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonLoadDatabase;
		private System.Windows.Forms.ListBox listBoxCharacters;
	}
}

