namespace CharacterEditor
{
	partial class FormEditor
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
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.groupBoxMain = new System.Windows.Forms.GroupBox();
			this.buttonHairColor = new System.Windows.Forms.Button();
			this.labelHairColor = new System.Windows.Forms.Label();
			this.labelHair = new System.Windows.Forms.Label();
			this.nudHair = new System.Windows.Forms.NumericUpDown();
			this.labelFace = new System.Windows.Forms.Label();
			this.nudFace = new System.Windows.Forms.NumericUpDown();
			this.labelGender = new System.Windows.Forms.Label();
			this.comboBoxGender = new System.Windows.Forms.ComboBox();
			this.comboBoxRace = new System.Windows.Forms.ComboBox();
			this.labelRace = new System.Windows.Forms.Label();
			this.labelLevel = new System.Windows.Forms.Label();
			this.nudLevel = new System.Windows.Forms.NumericUpDown();
			this.labelExperience = new System.Windows.Forms.Label();
			this.nudExperience = new System.Windows.Forms.NumericUpDown();
			this.buttonSaveCharacter = new System.Windows.Forms.Button();
			this.groupBoxMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudHair)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudFace)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudLevel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudExperience)).BeginInit();
			this.SuspendLayout();
			// 
			// textBoxName
			// 
			this.textBoxName.Enabled = false;
			this.textBoxName.Location = new System.Drawing.Point(12, 12);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(200, 20);
			this.textBoxName.TabIndex = 0;
			// 
			// groupBoxMain
			// 
			this.groupBoxMain.Controls.Add(this.buttonHairColor);
			this.groupBoxMain.Controls.Add(this.labelHairColor);
			this.groupBoxMain.Controls.Add(this.labelHair);
			this.groupBoxMain.Controls.Add(this.nudHair);
			this.groupBoxMain.Controls.Add(this.labelFace);
			this.groupBoxMain.Controls.Add(this.nudFace);
			this.groupBoxMain.Controls.Add(this.labelGender);
			this.groupBoxMain.Controls.Add(this.comboBoxGender);
			this.groupBoxMain.Controls.Add(this.comboBoxRace);
			this.groupBoxMain.Controls.Add(this.labelRace);
			this.groupBoxMain.Location = new System.Drawing.Point(12, 38);
			this.groupBoxMain.Name = "groupBoxMain";
			this.groupBoxMain.Size = new System.Drawing.Size(268, 162);
			this.groupBoxMain.TabIndex = 1;
			this.groupBoxMain.TabStop = false;
			this.groupBoxMain.Text = "Basic Information";
			// 
			// buttonHairColor
			// 
			this.buttonHairColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonHairColor.Location = new System.Drawing.Point(132, 128);
			this.buttonHairColor.Name = "buttonHairColor";
			this.buttonHairColor.Size = new System.Drawing.Size(23, 23);
			this.buttonHairColor.TabIndex = 9;
			this.buttonHairColor.UseVisualStyleBackColor = true;
			// 
			// labelHairColor
			// 
			this.labelHairColor.AutoSize = true;
			this.labelHairColor.Location = new System.Drawing.Point(6, 133);
			this.labelHairColor.Name = "labelHairColor";
			this.labelHairColor.Size = new System.Drawing.Size(53, 13);
			this.labelHairColor.TabIndex = 8;
			this.labelHairColor.Text = "Hair Color";
			// 
			// labelHair
			// 
			this.labelHair.AutoSize = true;
			this.labelHair.Location = new System.Drawing.Point(6, 104);
			this.labelHair.Name = "labelHair";
			this.labelHair.Size = new System.Drawing.Size(29, 13);
			this.labelHair.TabIndex = 7;
			this.labelHair.Text = "Hair:";
			// 
			// nudHair
			// 
			this.nudHair.Location = new System.Drawing.Point(132, 102);
			this.nudHair.Name = "nudHair";
			this.nudHair.Size = new System.Drawing.Size(120, 20);
			this.nudHair.TabIndex = 6;
			// 
			// labelFace
			// 
			this.labelFace.AutoSize = true;
			this.labelFace.Location = new System.Drawing.Point(6, 77);
			this.labelFace.Name = "labelFace";
			this.labelFace.Size = new System.Drawing.Size(34, 13);
			this.labelFace.TabIndex = 5;
			this.labelFace.Text = "Face:";
			// 
			// nudFace
			// 
			this.nudFace.Location = new System.Drawing.Point(132, 75);
			this.nudFace.Name = "nudFace";
			this.nudFace.Size = new System.Drawing.Size(120, 20);
			this.nudFace.TabIndex = 4;
			// 
			// labelGender
			// 
			this.labelGender.AutoSize = true;
			this.labelGender.Location = new System.Drawing.Point(6, 50);
			this.labelGender.Name = "labelGender";
			this.labelGender.Size = new System.Drawing.Size(45, 13);
			this.labelGender.TabIndex = 3;
			this.labelGender.Text = "Gender:";
			// 
			// comboBoxGender
			// 
			this.comboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxGender.FormattingEnabled = true;
			this.comboBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
			this.comboBoxGender.Location = new System.Drawing.Point(132, 47);
			this.comboBoxGender.Name = "comboBoxGender";
			this.comboBoxGender.Size = new System.Drawing.Size(121, 21);
			this.comboBoxGender.TabIndex = 2;
			// 
			// comboBoxRace
			// 
			this.comboBoxRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxRace.FormattingEnabled = true;
			this.comboBoxRace.Items.AddRange(new object[] {
            "Human",
            "Elf",
            "Dwaf",
            "Orc",
            "Goblin",
            "Lizard",
            "Undead",
            "Frogman"});
			this.comboBoxRace.Location = new System.Drawing.Point(132, 19);
			this.comboBoxRace.Name = "comboBoxRace";
			this.comboBoxRace.Size = new System.Drawing.Size(121, 21);
			this.comboBoxRace.TabIndex = 1;
			// 
			// labelRace
			// 
			this.labelRace.AutoSize = true;
			this.labelRace.Location = new System.Drawing.Point(6, 22);
			this.labelRace.Name = "labelRace";
			this.labelRace.Size = new System.Drawing.Size(36, 13);
			this.labelRace.TabIndex = 0;
			this.labelRace.Text = "Race:";
			// 
			// labelLevel
			// 
			this.labelLevel.AutoSize = true;
			this.labelLevel.Location = new System.Drawing.Point(218, 15);
			this.labelLevel.Name = "labelLevel";
			this.labelLevel.Size = new System.Drawing.Size(36, 13);
			this.labelLevel.TabIndex = 2;
			this.labelLevel.Text = "Level:";
			// 
			// nudLevel
			// 
			this.nudLevel.Location = new System.Drawing.Point(260, 12);
			this.nudLevel.Maximum = new decimal(new int[] {
            1073741822,
            0,
            0,
            0});
			this.nudLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudLevel.Name = "nudLevel";
			this.nudLevel.Size = new System.Drawing.Size(120, 20);
			this.nudLevel.TabIndex = 3;
			this.nudLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// labelExperience
			// 
			this.labelExperience.AutoSize = true;
			this.labelExperience.Location = new System.Drawing.Point(386, 15);
			this.labelExperience.Name = "labelExperience";
			this.labelExperience.Size = new System.Drawing.Size(63, 13);
			this.labelExperience.TabIndex = 4;
			this.labelExperience.Text = "Experience:";
			// 
			// nudExperience
			// 
			this.nudExperience.Location = new System.Drawing.Point(455, 12);
			this.nudExperience.Name = "nudExperience";
			this.nudExperience.Size = new System.Drawing.Size(120, 20);
			this.nudExperience.TabIndex = 5;
			// 
			// buttonSaveCharacter
			// 
			this.buttonSaveCharacter.Location = new System.Drawing.Point(617, 407);
			this.buttonSaveCharacter.Name = "buttonSaveCharacter";
			this.buttonSaveCharacter.Size = new System.Drawing.Size(75, 23);
			this.buttonSaveCharacter.TabIndex = 6;
			this.buttonSaveCharacter.Text = "Save";
			this.buttonSaveCharacter.UseVisualStyleBackColor = true;
			this.buttonSaveCharacter.Click += new System.EventHandler(this.ButtonSaveCharacterClick);
			// 
			// FormEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(704, 442);
			this.Controls.Add(this.buttonSaveCharacter);
			this.Controls.Add(this.nudExperience);
			this.Controls.Add(this.labelExperience);
			this.Controls.Add(this.nudLevel);
			this.Controls.Add(this.labelLevel);
			this.Controls.Add(this.groupBoxMain);
			this.Controls.Add(this.textBoxName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FormEditor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Character Editor";
			this.Shown += new System.EventHandler(this.FormEditorShown);
			this.groupBoxMain.ResumeLayout(false);
			this.groupBoxMain.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudHair)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudFace)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudLevel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudExperience)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.GroupBox groupBoxMain;
		private System.Windows.Forms.Label labelHair;
		private System.Windows.Forms.NumericUpDown nudHair;
		private System.Windows.Forms.Label labelFace;
		private System.Windows.Forms.NumericUpDown nudFace;
		private System.Windows.Forms.Label labelGender;
		private System.Windows.Forms.ComboBox comboBoxGender;
		private System.Windows.Forms.ComboBox comboBoxRace;
		private System.Windows.Forms.Label labelRace;
		private System.Windows.Forms.Button buttonHairColor;
		private System.Windows.Forms.Label labelHairColor;
		private System.Windows.Forms.Label labelLevel;
		private System.Windows.Forms.NumericUpDown nudLevel;
		private System.Windows.Forms.Label labelExperience;
		private System.Windows.Forms.NumericUpDown nudExperience;
		private System.Windows.Forms.Button buttonSaveCharacter;
	}
}