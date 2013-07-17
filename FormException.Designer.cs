namespace CharacterEditor
{
	partial class FormException
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormException));
			this.labelExceptionMessage = new System.Windows.Forms.Label();
			this.buttonClose = new System.Windows.Forms.Button();
			this.textBoxExceptionInformation = new System.Windows.Forms.TextBox();
			this.labelStackTrace = new System.Windows.Forms.Label();
			this.buttonCopyToClipboard = new System.Windows.Forms.Button();
			this.labelHelpMessage = new System.Windows.Forms.Label();
			this.buttonContinue = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelExceptionMessage
			// 
			this.labelExceptionMessage.AutoSize = true;
			this.labelExceptionMessage.Location = new System.Drawing.Point(12, 58);
			this.labelExceptionMessage.Name = "labelExceptionMessage";
			this.labelExceptionMessage.Size = new System.Drawing.Size(94, 13);
			this.labelExceptionMessage.TabIndex = 0;
			this.labelExceptionMessage.Text = "General Exception";
			// 
			// buttonClose
			// 
			this.buttonClose.Location = new System.Drawing.Point(537, 407);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(75, 23);
			this.buttonClose.TabIndex = 1;
			this.buttonClose.Text = "Close";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new System.EventHandler(this.ButtonCloseClick);
			// 
			// textBoxExceptionInformation
			// 
			this.textBoxExceptionInformation.Location = new System.Drawing.Point(12, 87);
			this.textBoxExceptionInformation.Multiline = true;
			this.textBoxExceptionInformation.Name = "textBoxExceptionInformation";
			this.textBoxExceptionInformation.ReadOnly = true;
			this.textBoxExceptionInformation.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBoxExceptionInformation.Size = new System.Drawing.Size(600, 314);
			this.textBoxExceptionInformation.TabIndex = 2;
			// 
			// labelStackTrace
			// 
			this.labelStackTrace.AutoSize = true;
			this.labelStackTrace.Location = new System.Drawing.Point(12, 71);
			this.labelStackTrace.Name = "labelStackTrace";
			this.labelStackTrace.Size = new System.Drawing.Size(69, 13);
			this.labelStackTrace.TabIndex = 3;
			this.labelStackTrace.Text = "Stack Trace:";
			// 
			// buttonCopyToClipboard
			// 
			this.buttonCopyToClipboard.Location = new System.Drawing.Point(337, 407);
			this.buttonCopyToClipboard.Name = "buttonCopyToClipboard";
			this.buttonCopyToClipboard.Size = new System.Drawing.Size(113, 23);
			this.buttonCopyToClipboard.TabIndex = 4;
			this.buttonCopyToClipboard.Text = "Copy to Clipboard";
			this.buttonCopyToClipboard.UseVisualStyleBackColor = true;
			this.buttonCopyToClipboard.Click += new System.EventHandler(this.ButtonCopyToClipboardClick);
			// 
			// labelHelpMessage
			// 
			this.labelHelpMessage.AutoSize = true;
			this.labelHelpMessage.Location = new System.Drawing.Point(12, 9);
			this.labelHelpMessage.Name = "labelHelpMessage";
			this.labelHelpMessage.Size = new System.Drawing.Size(393, 39);
			this.labelHelpMessage.TabIndex = 5;
			this.labelHelpMessage.Text = resources.GetString("labelHelpMessage.Text");
			// 
			// buttonContinue
			// 
			this.buttonContinue.Location = new System.Drawing.Point(456, 407);
			this.buttonContinue.Name = "buttonContinue";
			this.buttonContinue.Size = new System.Drawing.Size(75, 23);
			this.buttonContinue.TabIndex = 6;
			this.buttonContinue.Text = "Continue";
			this.buttonContinue.UseVisualStyleBackColor = true;
			this.buttonContinue.Click += new System.EventHandler(this.ButtonContinueClick);
			// 
			// FormException
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(624, 442);
			this.Controls.Add(this.buttonContinue);
			this.Controls.Add(this.labelHelpMessage);
			this.Controls.Add(this.buttonCopyToClipboard);
			this.Controls.Add(this.labelStackTrace);
			this.Controls.Add(this.textBoxExceptionInformation);
			this.Controls.Add(this.buttonClose);
			this.Controls.Add(this.labelExceptionMessage);
			this.Name = "FormException";
			this.Text = "Character Editor Exception Occurred";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormExceptionClosed);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelExceptionMessage;
		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.TextBox textBoxExceptionInformation;
		private System.Windows.Forms.Label labelStackTrace;
		private System.Windows.Forms.Button buttonCopyToClipboard;
		private System.Windows.Forms.Label labelHelpMessage;
		private System.Windows.Forms.Button buttonContinue;
	}
}