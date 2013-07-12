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
			this.groupBoxAppearance = new System.Windows.Forms.GroupBox();
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
			this.labelClass = new System.Windows.Forms.Label();
			this.comboBoxClass = new System.Windows.Forms.ComboBox();
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
			this.splitContainerWorkspace = new System.Windows.Forms.SplitContainer();
			this.tabControlWorkspace = new System.Windows.Forms.TabControl();
			this.tabPageCharacter = new System.Windows.Forms.TabPage();
			this.groupBoxSkills = new System.Windows.Forms.GroupBox();
			this.panelCharacterPreview = new System.Windows.Forms.Panel();
			this.labelCharacterPreview = new System.Windows.Forms.Label();
			this.groupBoxCharacterInformation = new System.Windows.Forms.GroupBox();
			this.labelCharacterName = new System.Windows.Forms.Label();
			this.labelSpecialization = new System.Windows.Forms.Label();
			this.comboBoxSpecialization = new System.Windows.Forms.ComboBox();
			this.tabPagePets = new System.Windows.Forms.TabPage();
			this.panelPetPreview = new System.Windows.Forms.Panel();
			this.labelPetPreview = new System.Windows.Forms.Label();
			this.tabPageInventory = new System.Windows.Forms.TabPage();
			this.groupBoxCoins = new System.Windows.Forms.GroupBox();
			this.labelPlatinumCoins = new System.Windows.Forms.Label();
			this.nudPlatinumCoins = new System.Windows.Forms.NumericUpDown();
			this.labelCoins = new System.Windows.Forms.Label();
			this.nudCoins = new System.Windows.Forms.NumericUpDown();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonLoadNewCharacter = new System.Windows.Forms.Button();
			this.groupBoxAppearance.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudHair)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudFace)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudLevel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudExperience)).BeginInit();
			this.groupBoxPetInformation.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudPetLevel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudPetExperience)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerWorkspace)).BeginInit();
			this.splitContainerWorkspace.Panel1.SuspendLayout();
			this.splitContainerWorkspace.Panel2.SuspendLayout();
			this.splitContainerWorkspace.SuspendLayout();
			this.tabControlWorkspace.SuspendLayout();
			this.tabPageCharacter.SuspendLayout();
			this.panelCharacterPreview.SuspendLayout();
			this.groupBoxCharacterInformation.SuspendLayout();
			this.tabPagePets.SuspendLayout();
			this.panelPetPreview.SuspendLayout();
			this.tabPageInventory.SuspendLayout();
			this.groupBoxCoins.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudPlatinumCoins)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudCoins)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBoxName
			// 
			this.textBoxName.Enabled = false;
			this.textBoxName.Location = new System.Drawing.Point(141, 19);
			this.textBoxName.MaxLength = 15;
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(121, 20);
			this.textBoxName.TabIndex = 0;
			// 
			// groupBoxAppearance
			// 
			this.groupBoxAppearance.Controls.Add(this.buttonHairColor);
			this.groupBoxAppearance.Controls.Add(this.labelHairColor);
			this.groupBoxAppearance.Controls.Add(this.labelHair);
			this.groupBoxAppearance.Controls.Add(this.nudHair);
			this.groupBoxAppearance.Controls.Add(this.labelFace);
			this.groupBoxAppearance.Controls.Add(this.nudFace);
			this.groupBoxAppearance.Controls.Add(this.labelGender);
			this.groupBoxAppearance.Controls.Add(this.comboBoxGender);
			this.groupBoxAppearance.Controls.Add(this.comboBoxRace);
			this.groupBoxAppearance.Controls.Add(this.labelRace);
			this.groupBoxAppearance.Location = new System.Drawing.Point(280, 6);
			this.groupBoxAppearance.Name = "groupBoxAppearance";
			this.groupBoxAppearance.Size = new System.Drawing.Size(268, 191);
			this.groupBoxAppearance.TabIndex = 1;
			this.groupBoxAppearance.TabStop = false;
			this.groupBoxAppearance.Text = "Appearance";
			// 
			// buttonHairColor
			// 
			this.buttonHairColor.BackColor = System.Drawing.Color.Black;
			this.buttonHairColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.buttonHairColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.buttonHairColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonHairColor.Location = new System.Drawing.Point(141, 125);
			this.buttonHairColor.Name = "buttonHairColor";
			this.buttonHairColor.Size = new System.Drawing.Size(21, 21);
			this.buttonHairColor.TabIndex = 9;
			this.buttonHairColor.UseVisualStyleBackColor = false;
			this.buttonHairColor.Click += new System.EventHandler(this.ButtonHairColorClick);
			// 
			// labelHairColor
			// 
			this.labelHairColor.AutoSize = true;
			this.labelHairColor.Location = new System.Drawing.Point(6, 129);
			this.labelHairColor.Name = "labelHairColor";
			this.labelHairColor.Size = new System.Drawing.Size(56, 13);
			this.labelHairColor.TabIndex = 8;
			this.labelHairColor.Text = "Hair Color:";
			// 
			// labelHair
			// 
			this.labelHair.AutoSize = true;
			this.labelHair.Location = new System.Drawing.Point(6, 101);
			this.labelHair.Name = "labelHair";
			this.labelHair.Size = new System.Drawing.Size(29, 13);
			this.labelHair.TabIndex = 7;
			this.labelHair.Text = "Hair:";
			// 
			// nudHair
			// 
			this.nudHair.Location = new System.Drawing.Point(141, 99);
			this.nudHair.Name = "nudHair";
			this.nudHair.Size = new System.Drawing.Size(121, 20);
			this.nudHair.TabIndex = 6;
			// 
			// labelFace
			// 
			this.labelFace.AutoSize = true;
			this.labelFace.Location = new System.Drawing.Point(6, 75);
			this.labelFace.Name = "labelFace";
			this.labelFace.Size = new System.Drawing.Size(34, 13);
			this.labelFace.TabIndex = 5;
			this.labelFace.Text = "Face:";
			// 
			// nudFace
			// 
			this.nudFace.Location = new System.Drawing.Point(141, 73);
			this.nudFace.Name = "nudFace";
			this.nudFace.Size = new System.Drawing.Size(121, 20);
			this.nudFace.TabIndex = 4;
			// 
			// labelGender
			// 
			this.labelGender.AutoSize = true;
			this.labelGender.Location = new System.Drawing.Point(6, 49);
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
			this.comboBoxGender.Location = new System.Drawing.Point(141, 46);
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
            "Dwarf",
            "Orc",
            "Goblin",
            "Lizard",
            "Undead",
            "Frogman"});
			this.comboBoxRace.Location = new System.Drawing.Point(141, 18);
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
			// labelClass
			// 
			this.labelClass.AutoSize = true;
			this.labelClass.Location = new System.Drawing.Point(6, 50);
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
            "Warrior",
            "Ranger",
            "Mage",
            "Rogue"});
			this.comboBoxClass.Location = new System.Drawing.Point(141, 45);
			this.comboBoxClass.Name = "comboBoxClass";
			this.comboBoxClass.Size = new System.Drawing.Size(121, 21);
			this.comboBoxClass.TabIndex = 10;
			this.comboBoxClass.SelectedIndexChanged += new System.EventHandler(this.ComboBoxClassSelectedIndexChanged);
			// 
			// labelLevel
			// 
			this.labelLevel.AutoSize = true;
			this.labelLevel.Location = new System.Drawing.Point(6, 101);
			this.labelLevel.Name = "labelLevel";
			this.labelLevel.Size = new System.Drawing.Size(36, 13);
			this.labelLevel.TabIndex = 2;
			this.labelLevel.Text = "Level:";
			// 
			// nudLevel
			// 
			this.nudLevel.Location = new System.Drawing.Point(141, 99);
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
			this.nudLevel.Size = new System.Drawing.Size(121, 20);
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
			this.labelExperience.Location = new System.Drawing.Point(6, 127);
			this.labelExperience.Name = "labelExperience";
			this.labelExperience.Size = new System.Drawing.Size(63, 13);
			this.labelExperience.TabIndex = 4;
			this.labelExperience.Text = "Experience:";
			// 
			// nudExperience
			// 
			this.nudExperience.Location = new System.Drawing.Point(141, 125);
			this.nudExperience.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.nudExperience.Name = "nudExperience";
			this.nudExperience.Size = new System.Drawing.Size(121, 20);
			this.nudExperience.TabIndex = 5;
			// 
			// buttonSaveCharacter
			// 
			this.buttonSaveCharacter.Location = new System.Drawing.Point(617, 14);
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
			this.groupBoxPetInformation.Location = new System.Drawing.Point(6, 6);
			this.groupBoxPetInformation.Name = "groupBoxPetInformation";
			this.groupBoxPetInformation.Size = new System.Drawing.Size(268, 191);
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
			this.nudPetLevel.Location = new System.Drawing.Point(141, 46);
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
			this.nudPetLevel.Size = new System.Drawing.Size(121, 20);
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
			this.nudPetExperience.Location = new System.Drawing.Point(141, 72);
			this.nudPetExperience.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.nudPetExperience.Name = "nudPetExperience";
			this.nudPetExperience.Size = new System.Drawing.Size(121, 20);
			this.nudPetExperience.TabIndex = 2;
			// 
			// comboBoxPetKind
			// 
			this.comboBoxPetKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxPetKind.FormattingEnabled = true;
			this.comboBoxPetKind.Items.AddRange(new object[] {
            "None",
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
            "Monkey",
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
            "Duckbill",
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
            "Beetle (Bark)",
            "Beetle (Fire)",
            "Beetle (Snout)",
            "Beetle (Lemon)",
            "Crab",
            "Bumblebee"});
			this.comboBoxPetKind.Location = new System.Drawing.Point(141, 19);
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
			// splitContainerWorkspace
			// 
			this.splitContainerWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerWorkspace.IsSplitterFixed = true;
			this.splitContainerWorkspace.Location = new System.Drawing.Point(0, 0);
			this.splitContainerWorkspace.Name = "splitContainerWorkspace";
			this.splitContainerWorkspace.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainerWorkspace.Panel1
			// 
			this.splitContainerWorkspace.Panel1.Controls.Add(this.tabControlWorkspace);
			// 
			// splitContainerWorkspace.Panel2
			// 
			this.splitContainerWorkspace.Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
			this.splitContainerWorkspace.Panel2.Controls.Add(this.buttonLoadNewCharacter);
			this.splitContainerWorkspace.Panel2.Controls.Add(this.buttonSaveCharacter);
			this.splitContainerWorkspace.Size = new System.Drawing.Size(704, 442);
			this.splitContainerWorkspace.SplitterDistance = 389;
			this.splitContainerWorkspace.TabIndex = 8;
			// 
			// tabControlWorkspace
			// 
			this.tabControlWorkspace.Controls.Add(this.tabPageCharacter);
			this.tabControlWorkspace.Controls.Add(this.tabPagePets);
			this.tabControlWorkspace.Controls.Add(this.tabPageInventory);
			this.tabControlWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControlWorkspace.Location = new System.Drawing.Point(0, 0);
			this.tabControlWorkspace.Name = "tabControlWorkspace";
			this.tabControlWorkspace.SelectedIndex = 0;
			this.tabControlWorkspace.Size = new System.Drawing.Size(704, 389);
			this.tabControlWorkspace.TabIndex = 8;
			// 
			// tabPageCharacter
			// 
			this.tabPageCharacter.Controls.Add(this.groupBoxSkills);
			this.tabPageCharacter.Controls.Add(this.panelCharacterPreview);
			this.tabPageCharacter.Controls.Add(this.groupBoxCharacterInformation);
			this.tabPageCharacter.Controls.Add(this.groupBoxAppearance);
			this.tabPageCharacter.Location = new System.Drawing.Point(4, 22);
			this.tabPageCharacter.Name = "tabPageCharacter";
			this.tabPageCharacter.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageCharacter.Size = new System.Drawing.Size(696, 363);
			this.tabPageCharacter.TabIndex = 0;
			this.tabPageCharacter.Text = "Character";
			this.tabPageCharacter.UseVisualStyleBackColor = true;
			// 
			// groupBoxSkills
			// 
			this.groupBoxSkills.Location = new System.Drawing.Point(6, 203);
			this.groupBoxSkills.Name = "groupBoxSkills";
			this.groupBoxSkills.Size = new System.Drawing.Size(268, 154);
			this.groupBoxSkills.TabIndex = 8;
			this.groupBoxSkills.TabStop = false;
			this.groupBoxSkills.Text = "Skills";
			// 
			// panelCharacterPreview
			// 
			this.panelCharacterPreview.BackColor = System.Drawing.Color.DarkGray;
			this.panelCharacterPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelCharacterPreview.Controls.Add(this.labelCharacterPreview);
			this.panelCharacterPreview.Location = new System.Drawing.Point(554, 6);
			this.panelCharacterPreview.Name = "panelCharacterPreview";
			this.panelCharacterPreview.Size = new System.Drawing.Size(136, 136);
			this.panelCharacterPreview.TabIndex = 7;
			// 
			// labelCharacterPreview
			// 
			this.labelCharacterPreview.AutoSize = true;
			this.labelCharacterPreview.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelCharacterPreview.ForeColor = System.Drawing.Color.White;
			this.labelCharacterPreview.Location = new System.Drawing.Point(0, 0);
			this.labelCharacterPreview.Name = "labelCharacterPreview";
			this.labelCharacterPreview.Padding = new System.Windows.Forms.Padding(20, 60, 20, 60);
			this.labelCharacterPreview.Size = new System.Drawing.Size(134, 133);
			this.labelCharacterPreview.TabIndex = 0;
			this.labelCharacterPreview.Text = "Character Preview";
			// 
			// groupBoxCharacterInformation
			// 
			this.groupBoxCharacterInformation.Controls.Add(this.labelCharacterName);
			this.groupBoxCharacterInformation.Controls.Add(this.labelSpecialization);
			this.groupBoxCharacterInformation.Controls.Add(this.textBoxName);
			this.groupBoxCharacterInformation.Controls.Add(this.comboBoxSpecialization);
			this.groupBoxCharacterInformation.Controls.Add(this.nudExperience);
			this.groupBoxCharacterInformation.Controls.Add(this.labelExperience);
			this.groupBoxCharacterInformation.Controls.Add(this.labelClass);
			this.groupBoxCharacterInformation.Controls.Add(this.comboBoxClass);
			this.groupBoxCharacterInformation.Controls.Add(this.labelLevel);
			this.groupBoxCharacterInformation.Controls.Add(this.nudLevel);
			this.groupBoxCharacterInformation.Location = new System.Drawing.Point(6, 6);
			this.groupBoxCharacterInformation.Name = "groupBoxCharacterInformation";
			this.groupBoxCharacterInformation.Size = new System.Drawing.Size(268, 191);
			this.groupBoxCharacterInformation.TabIndex = 6;
			this.groupBoxCharacterInformation.TabStop = false;
			this.groupBoxCharacterInformation.Text = "Character Information";
			// 
			// labelCharacterName
			// 
			this.labelCharacterName.AutoSize = true;
			this.labelCharacterName.Location = new System.Drawing.Point(6, 22);
			this.labelCharacterName.Name = "labelCharacterName";
			this.labelCharacterName.Size = new System.Drawing.Size(38, 13);
			this.labelCharacterName.TabIndex = 1;
			this.labelCharacterName.Text = "Name:";
			// 
			// labelSpecialization
			// 
			this.labelSpecialization.AutoSize = true;
			this.labelSpecialization.Location = new System.Drawing.Point(6, 75);
			this.labelSpecialization.Name = "labelSpecialization";
			this.labelSpecialization.Size = new System.Drawing.Size(75, 13);
			this.labelSpecialization.TabIndex = 13;
			this.labelSpecialization.Text = "Specialization:";
			// 
			// comboBoxSpecialization
			// 
			this.comboBoxSpecialization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxSpecialization.FormattingEnabled = true;
			this.comboBoxSpecialization.Location = new System.Drawing.Point(141, 72);
			this.comboBoxSpecialization.Name = "comboBoxSpecialization";
			this.comboBoxSpecialization.Size = new System.Drawing.Size(121, 21);
			this.comboBoxSpecialization.TabIndex = 12;
			// 
			// tabPagePets
			// 
			this.tabPagePets.Controls.Add(this.panelPetPreview);
			this.tabPagePets.Controls.Add(this.groupBoxPetInformation);
			this.tabPagePets.Location = new System.Drawing.Point(4, 22);
			this.tabPagePets.Name = "tabPagePets";
			this.tabPagePets.Padding = new System.Windows.Forms.Padding(3);
			this.tabPagePets.Size = new System.Drawing.Size(696, 363);
			this.tabPagePets.TabIndex = 1;
			this.tabPagePets.Text = "Pets";
			this.tabPagePets.UseVisualStyleBackColor = true;
			// 
			// panelPetPreview
			// 
			this.panelPetPreview.BackColor = System.Drawing.Color.DarkGray;
			this.panelPetPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelPetPreview.Controls.Add(this.labelPetPreview);
			this.panelPetPreview.Location = new System.Drawing.Point(554, 6);
			this.panelPetPreview.Name = "panelPetPreview";
			this.panelPetPreview.Size = new System.Drawing.Size(136, 136);
			this.panelPetPreview.TabIndex = 8;
			// 
			// labelPetPreview
			// 
			this.labelPetPreview.AutoSize = true;
			this.labelPetPreview.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelPetPreview.ForeColor = System.Drawing.Color.White;
			this.labelPetPreview.Location = new System.Drawing.Point(0, 0);
			this.labelPetPreview.Name = "labelPetPreview";
			this.labelPetPreview.Padding = new System.Windows.Forms.Padding(20, 60, 20, 60);
			this.labelPetPreview.Size = new System.Drawing.Size(134, 133);
			this.labelPetPreview.TabIndex = 0;
			this.labelPetPreview.Text = "Character Preview";
			// 
			// tabPageInventory
			// 
			this.tabPageInventory.Controls.Add(this.groupBoxCoins);
			this.tabPageInventory.Controls.Add(this.panel1);
			this.tabPageInventory.Location = new System.Drawing.Point(4, 22);
			this.tabPageInventory.Name = "tabPageInventory";
			this.tabPageInventory.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageInventory.Size = new System.Drawing.Size(696, 363);
			this.tabPageInventory.TabIndex = 2;
			this.tabPageInventory.Text = "Inventory";
			this.tabPageInventory.UseVisualStyleBackColor = true;
			// 
			// groupBoxCoins
			// 
			this.groupBoxCoins.Controls.Add(this.labelPlatinumCoins);
			this.groupBoxCoins.Controls.Add(this.nudPlatinumCoins);
			this.groupBoxCoins.Controls.Add(this.labelCoins);
			this.groupBoxCoins.Controls.Add(this.nudCoins);
			this.groupBoxCoins.Enabled = false;
			this.groupBoxCoins.Location = new System.Drawing.Point(6, 6);
			this.groupBoxCoins.Name = "groupBoxCoins";
			this.groupBoxCoins.Size = new System.Drawing.Size(268, 191);
			this.groupBoxCoins.TabIndex = 12;
			this.groupBoxCoins.TabStop = false;
			this.groupBoxCoins.Text = "Coins";
			// 
			// labelPlatinumCoins
			// 
			this.labelPlatinumCoins.AutoSize = true;
			this.labelPlatinumCoins.Location = new System.Drawing.Point(6, 47);
			this.labelPlatinumCoins.Name = "labelPlatinumCoins";
			this.labelPlatinumCoins.Size = new System.Drawing.Size(79, 13);
			this.labelPlatinumCoins.TabIndex = 13;
			this.labelPlatinumCoins.Text = "Platinum Coins:";
			// 
			// nudPlatinumCoins
			// 
			this.nudPlatinumCoins.Location = new System.Drawing.Point(141, 45);
			this.nudPlatinumCoins.Name = "nudPlatinumCoins";
			this.nudPlatinumCoins.Size = new System.Drawing.Size(121, 20);
			this.nudPlatinumCoins.TabIndex = 12;
			// 
			// labelCoins
			// 
			this.labelCoins.AutoSize = true;
			this.labelCoins.Location = new System.Drawing.Point(6, 21);
			this.labelCoins.Name = "labelCoins";
			this.labelCoins.Size = new System.Drawing.Size(36, 13);
			this.labelCoins.TabIndex = 10;
			this.labelCoins.Text = "Coins:";
			// 
			// nudCoins
			// 
			this.nudCoins.Location = new System.Drawing.Point(141, 19);
			this.nudCoins.Name = "nudCoins";
			this.nudCoins.Size = new System.Drawing.Size(121, 20);
			this.nudCoins.TabIndex = 11;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkGray;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(554, 6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(136, 136);
			this.panel1.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(20, 60, 20, 60);
			this.label1.Size = new System.Drawing.Size(134, 133);
			this.label1.TabIndex = 0;
			this.label1.Text = "Character Preview";
			// 
			// buttonLoadNewCharacter
			// 
			this.buttonLoadNewCharacter.Location = new System.Drawing.Point(492, 14);
			this.buttonLoadNewCharacter.Name = "buttonLoadNewCharacter";
			this.buttonLoadNewCharacter.Size = new System.Drawing.Size(119, 23);
			this.buttonLoadNewCharacter.TabIndex = 7;
			this.buttonLoadNewCharacter.Text = "Load new Character";
			this.buttonLoadNewCharacter.UseVisualStyleBackColor = true;
			this.buttonLoadNewCharacter.Click += new System.EventHandler(this.ButtonLoadNewCharacterClick);
			// 
			// FormEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(704, 442);
			this.Controls.Add(this.splitContainerWorkspace);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FormEditor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Character Editor";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEditorClosing);
			this.Shown += new System.EventHandler(this.FormEditorShown);
			this.groupBoxAppearance.ResumeLayout(false);
			this.groupBoxAppearance.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudHair)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudFace)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudLevel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudExperience)).EndInit();
			this.groupBoxPetInformation.ResumeLayout(false);
			this.groupBoxPetInformation.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudPetLevel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudPetExperience)).EndInit();
			this.splitContainerWorkspace.Panel1.ResumeLayout(false);
			this.splitContainerWorkspace.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainerWorkspace)).EndInit();
			this.splitContainerWorkspace.ResumeLayout(false);
			this.tabControlWorkspace.ResumeLayout(false);
			this.tabPageCharacter.ResumeLayout(false);
			this.panelCharacterPreview.ResumeLayout(false);
			this.panelCharacterPreview.PerformLayout();
			this.groupBoxCharacterInformation.ResumeLayout(false);
			this.groupBoxCharacterInformation.PerformLayout();
			this.tabPagePets.ResumeLayout(false);
			this.panelPetPreview.ResumeLayout(false);
			this.panelPetPreview.PerformLayout();
			this.tabPageInventory.ResumeLayout(false);
			this.groupBoxCoins.ResumeLayout(false);
			this.groupBoxCoins.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudPlatinumCoins)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudCoins)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.GroupBox groupBoxAppearance;
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
		private System.Windows.Forms.SplitContainer splitContainerWorkspace;
		private System.Windows.Forms.TabControl tabControlWorkspace;
		private System.Windows.Forms.TabPage tabPageCharacter;
		private System.Windows.Forms.TabPage tabPagePets;
		private System.Windows.Forms.Button buttonLoadNewCharacter;
		private System.Windows.Forms.GroupBox groupBoxCharacterInformation;
		private System.Windows.Forms.Label labelSpecialization;
		private System.Windows.Forms.ComboBox comboBoxSpecialization;
		private System.Windows.Forms.Panel panelCharacterPreview;
		private System.Windows.Forms.Label labelCharacterPreview;
		private System.Windows.Forms.GroupBox groupBoxSkills;
		private System.Windows.Forms.Label labelCharacterName;
        private System.Windows.Forms.Panel panelPetPreview;
        private System.Windows.Forms.Label labelPetPreview;
		private System.Windows.Forms.TabPage tabPageInventory;
		private System.Windows.Forms.GroupBox groupBoxCoins;
		private System.Windows.Forms.Label labelPlatinumCoins;
		private System.Windows.Forms.NumericUpDown nudPlatinumCoins;
		private System.Windows.Forms.Label labelCoins;
		private System.Windows.Forms.NumericUpDown nudCoins;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
	}
}