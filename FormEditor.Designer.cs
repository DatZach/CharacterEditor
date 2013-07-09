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
			this.labelClass = new System.Windows.Forms.Label();
			this.comboBoxClass = new System.Windows.Forms.ComboBox();
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
			this.groupBoxPetInformation = new System.Windows.Forms.GroupBox();
			this.labelPetLevel = new System.Windows.Forms.Label();
			this.nudPetLevel = new System.Windows.Forms.NumericUpDown();
			this.labelPetXP = new System.Windows.Forms.Label();
			this.nudPetExperience = new System.Windows.Forms.NumericUpDown();
			this.comboBoxPetKind = new System.Windows.Forms.ComboBox();
			this.labelPetKind = new System.Windows.Forms.Label();
			this.groupBoxMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudHair)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudFace)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudLevel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudExperience)).BeginInit();
			this.groupBoxPetInformation.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudPetLevel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudPetExperience)).BeginInit();
			this.SuspendLayout();
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(12, 12);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(200, 20);
			this.textBoxName.TabIndex = 0;
			// 
			// groupBoxMain
			// 
			this.groupBoxMain.Controls.Add(this.labelClass);
			this.groupBoxMain.Controls.Add(this.comboBoxClass);
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
			this.groupBoxMain.Size = new System.Drawing.Size(268, 191);
			this.groupBoxMain.TabIndex = 1;
			this.groupBoxMain.TabStop = false;
			this.groupBoxMain.Text = "Basic Information";
			// 
			// labelClass
			// 
			this.labelClass.AutoSize = true;
			this.labelClass.Location = new System.Drawing.Point(7, 78);
			this.labelClass.Name = "labelClass";
			this.labelClass.Size = new System.Drawing.Size(35, 13);
			this.labelClass.TabIndex = 11;
			this.labelClass.Text = "Class:";
			// 
			// comboBoxClass
			// 
			this.comboBoxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxClass.FormattingEnabled = true;
			this.comboBoxClass.Items.AddRange(new object[] {
            "Warior",
            "Ranger",
            "Mage",
            "Rogue"});
			this.comboBoxClass.Location = new System.Drawing.Point(132, 75);
			this.comboBoxClass.Name = "comboBoxClass";
			this.comboBoxClass.Size = new System.Drawing.Size(121, 21);
			this.comboBoxClass.TabIndex = 10;
			// 
			// buttonHairColor
			// 
			this.buttonHairColor.BackColor = System.Drawing.Color.Black;
			this.buttonHairColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonHairColor.Location = new System.Drawing.Point(132, 156);
			this.buttonHairColor.Name = "buttonHairColor";
			this.buttonHairColor.Size = new System.Drawing.Size(21, 21);
			this.buttonHairColor.TabIndex = 9;
			this.buttonHairColor.UseVisualStyleBackColor = false;
			this.buttonHairColor.Click += new System.EventHandler(this.ButtonHairColorClick);
			// 
			// labelHairColor
			// 
			this.labelHairColor.AutoSize = true;
			this.labelHairColor.Location = new System.Drawing.Point(7, 160);
			this.labelHairColor.Name = "labelHairColor";
			this.labelHairColor.Size = new System.Drawing.Size(56, 13);
			this.labelHairColor.TabIndex = 8;
			this.labelHairColor.Text = "Hair Color:";
			// 
			// labelHair
			// 
			this.labelHair.AutoSize = true;
			this.labelHair.Location = new System.Drawing.Point(6, 132);
			this.labelHair.Name = "labelHair";
			this.labelHair.Size = new System.Drawing.Size(29, 13);
			this.labelHair.TabIndex = 7;
			this.labelHair.Text = "Hair:";
			// 
			// nudHair
			// 
			this.nudHair.Location = new System.Drawing.Point(132, 130);
			this.nudHair.Name = "nudHair";
			this.nudHair.Size = new System.Drawing.Size(120, 20);
			this.nudHair.TabIndex = 6;
			// 
			// labelFace
			// 
			this.labelFace.AutoSize = true;
			this.labelFace.Location = new System.Drawing.Point(6, 106);
			this.labelFace.Name = "labelFace";
			this.labelFace.Size = new System.Drawing.Size(34, 13);
			this.labelFace.TabIndex = 5;
			this.labelFace.Text = "Face:";
			// 
			// nudFace
			// 
			this.nudFace.Location = new System.Drawing.Point(132, 104);
			this.nudFace.Name = "nudFace";
			this.nudFace.Size = new System.Drawing.Size(120, 20);
			this.nudFace.TabIndex = 4;
			// 
			// labelGender
			// 
			this.labelGender.AutoSize = true;
			this.labelGender.Location = new System.Drawing.Point(7, 50);
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
			this.comboBoxGender.SelectedIndexChanged += new System.EventHandler(this.ComboBoxRaceSelectedIndexChanged);
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
			this.comboBoxRace.SelectedIndexChanged += new System.EventHandler(this.ComboBoxRaceSelectedIndexChanged);
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
			this.nudLevel.ValueChanged += new System.EventHandler(this.NudLevelValueChanged);
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
			this.nudExperience.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
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
			// groupBoxPetInformation
			// 
			this.groupBoxPetInformation.Controls.Add(this.labelPetLevel);
			this.groupBoxPetInformation.Controls.Add(this.nudPetLevel);
			this.groupBoxPetInformation.Controls.Add(this.labelPetXP);
			this.groupBoxPetInformation.Controls.Add(this.nudPetExperience);
			this.groupBoxPetInformation.Controls.Add(this.comboBoxPetKind);
			this.groupBoxPetInformation.Controls.Add(this.labelPetKind);
			this.groupBoxPetInformation.Location = new System.Drawing.Point(286, 38);
			this.groupBoxPetInformation.Name = "groupBoxPetInformation";
			this.groupBoxPetInformation.Size = new System.Drawing.Size(200, 104);
			this.groupBoxPetInformation.TabIndex = 7;
			this.groupBoxPetInformation.TabStop = false;
			this.groupBoxPetInformation.Text = "Pet Information";
			// 
			// labelPetLevel
			// 
			this.labelPetLevel.AutoSize = true;
			this.labelPetLevel.Location = new System.Drawing.Point(6, 48);
			this.labelPetLevel.Name = "labelPetLevel";
			this.labelPetLevel.Size = new System.Drawing.Size(36, 13);
			this.labelPetLevel.TabIndex = 5;
			this.labelPetLevel.Text = "Level:";
			// 
			// nudPetLevel
			// 
			this.nudPetLevel.Location = new System.Drawing.Point(74, 46);
			this.nudPetLevel.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
			this.nudPetLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudPetLevel.Name = "nudPetLevel";
			this.nudPetLevel.Size = new System.Drawing.Size(120, 20);
			this.nudPetLevel.TabIndex = 4;
			this.nudPetLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// labelPetXP
			// 
			this.labelPetXP.AutoSize = true;
			this.labelPetXP.Location = new System.Drawing.Point(6, 74);
			this.labelPetXP.Name = "labelPetXP";
			this.labelPetXP.Size = new System.Drawing.Size(63, 13);
			this.labelPetXP.TabIndex = 3;
			this.labelPetXP.Text = "Experience:";
			// 
			// nudPetExperience
			// 
			this.nudPetExperience.Location = new System.Drawing.Point(74, 72);
			this.nudPetExperience.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.nudPetExperience.Name = "nudPetExperience";
			this.nudPetExperience.Size = new System.Drawing.Size(120, 20);
			this.nudPetExperience.TabIndex = 2;
			// 
			// comboBoxPetKind
			// 
			this.comboBoxPetKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxPetKind.FormattingEnabled = true;
			this.comboBoxPetKind.Items.AddRange(new object[] {
            "Collie",
            "Shepherd Dog",
            "Alpaca",
            "Alpaca (Brown)",
            "Turtle",
            "Terrier",
            "Terrier (Scottish)",
            "Wolf",
            "Cat",
            "Cat (Brown)",
            "Cat (White)",
            "Pig",
            "Sheep",
            "Bunny",
            "Porcupine",
            "Slime (Green)",
            "Slime (Pink)",
            "Slime (Yellow)",
            "Slime (Blue)",
            "Money",
            "Hornet",
            "Crow",
            "Chicken",
            "Seagull",
            "Parrot",
            "Bat",
            "Fly",
            "Midge",
            "Mosquito",
            "Runner (Plain)",
            "Runner (Leaf)",
            "Runner (Snow)",
            "Runner (Desert)",
            "Peacock",
            "Frog",
            "Devourer",
            "Duckbull",
            "Crocodile",
            "Imp",
            "Spitter",
            "Mole",
            "Biter",
            "Koala",
            "Squirrel",
            "Raccoon",
            "Owl",
            "Penguin",
            "Horse",
            "Camel",
            "Beetle (Snout)",
            "Beetle (Lemon)",
            "Crab",
            "Bumblebee"});
			this.comboBoxPetKind.Location = new System.Drawing.Point(73, 19);
			this.comboBoxPetKind.Name = "comboBoxPetKind";
			this.comboBoxPetKind.Size = new System.Drawing.Size(121, 21);
			this.comboBoxPetKind.TabIndex = 1;
			// 
			// labelPetKind
			// 
			this.labelPetKind.AutoSize = true;
			this.labelPetKind.Location = new System.Drawing.Point(6, 22);
			this.labelPetKind.Name = "labelPetKind";
			this.labelPetKind.Size = new System.Drawing.Size(31, 13);
			this.labelPetKind.TabIndex = 0;
			this.labelPetKind.Text = "Kind:";
			// 
			// FormEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(704, 442);
			this.Controls.Add(this.groupBoxPetInformation);
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
			this.groupBoxPetInformation.ResumeLayout(false);
			this.groupBoxPetInformation.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudPetLevel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudPetExperience)).EndInit();
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
		private System.Windows.Forms.GroupBox groupBoxPetInformation;
		private System.Windows.Forms.Label labelPetKind;
		private System.Windows.Forms.ComboBox comboBoxPetKind;
		private System.Windows.Forms.Label labelPetLevel;
		private System.Windows.Forms.NumericUpDown nudPetLevel;
		private System.Windows.Forms.Label labelPetXP;
		private System.Windows.Forms.NumericUpDown nudPetExperience;
		private System.Windows.Forms.Label labelClass;
		private System.Windows.Forms.ComboBox comboBoxClass;
	}
}