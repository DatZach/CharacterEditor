namespace CharacterEditor.Forms
{
	partial class Editor
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.groupBoxAppearance = new System.Windows.Forms.GroupBox();
			this.buttonHairColor = new System.Windows.Forms.Button();
			this.labelHairColor = new System.Windows.Forms.Label();
			this.labelHair = new System.Windows.Forms.Label();
			this.nudHair = new CharacterEditor.Forms.SafeNumericUpDown();
			this.labelFace = new System.Windows.Forms.Label();
			this.nudFace = new CharacterEditor.Forms.SafeNumericUpDown();
			this.labelGender = new System.Windows.Forms.Label();
			this.comboBoxGender = new System.Windows.Forms.ComboBox();
			this.comboBoxRace = new System.Windows.Forms.ComboBox();
			this.labelRace = new System.Windows.Forms.Label();
			this.labelClass = new System.Windows.Forms.Label();
			this.comboBoxClass = new System.Windows.Forms.ComboBox();
			this.labelLevel = new System.Windows.Forms.Label();
			this.nudLevel = new CharacterEditor.Forms.SafeNumericUpDown();
			this.labelExperience = new System.Windows.Forms.Label();
			this.nudExperience = new CharacterEditor.Forms.SafeNumericUpDown();
			this.buttonSaveCharacter = new System.Windows.Forms.Button();
			this.groupBoxPetInformation = new System.Windows.Forms.GroupBox();
			this.labelPetName = new System.Windows.Forms.Label();
			this.textBoxPetName = new System.Windows.Forms.TextBox();
			this.labelPetLevel = new System.Windows.Forms.Label();
			this.nudPetLevel = new CharacterEditor.Forms.SafeNumericUpDown();
			this.labelPetXP = new System.Windows.Forms.Label();
			this.nudPetExperience = new CharacterEditor.Forms.SafeNumericUpDown();
			this.comboBoxPetKind = new System.Windows.Forms.ComboBox();
			this.labelPetKind = new System.Windows.Forms.Label();
			this.splitContainerWorkspace = new System.Windows.Forms.SplitContainer();
			this.tabControlWorkspace = new System.Windows.Forms.TabControl();
			this.tabPageCharacter = new System.Windows.Forms.TabPage();
			this.groupBoxSkills = new System.Windows.Forms.GroupBox();
			this.labelClimbingSkillLevel = new System.Windows.Forms.Label();
			this.labelPetRidingSkillLevel = new System.Windows.Forms.Label();
			this.labelPetMasterSkillLevel = new System.Windows.Forms.Label();
			this.labelSailingSkillLevel = new System.Windows.Forms.Label();
			this.labelSwimmingSkillLevel = new System.Windows.Forms.Label();
			this.labelHangGlidingSkillLevel = new System.Windows.Forms.Label();
			this.labelTierThreeSkillLevel = new System.Windows.Forms.Label();
			this.labelTierTwoSkillLevel = new System.Windows.Forms.Label();
			this.labelTierOneSkillLevel = new System.Windows.Forms.Label();
			this.nudSailingSkillLevel = new CharacterEditor.Forms.SafeNumericUpDown();
			this.nudSwimmingSkillLevel = new CharacterEditor.Forms.SafeNumericUpDown();
			this.nudHangGlidingSkillLevel = new CharacterEditor.Forms.SafeNumericUpDown();
			this.nudClimbingSkillLevel = new CharacterEditor.Forms.SafeNumericUpDown();
			this.nudPetRidingSkillLevel = new CharacterEditor.Forms.SafeNumericUpDown();
			this.nudPetMasterSkillLevel = new CharacterEditor.Forms.SafeNumericUpDown();
			this.nudTierThreeSkillLevel = new CharacterEditor.Forms.SafeNumericUpDown();
			this.nudTierTwoSkillLevel = new CharacterEditor.Forms.SafeNumericUpDown();
			this.nudTierOneSkillLevel = new CharacterEditor.Forms.SafeNumericUpDown();
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
			this.groupBoxItemStats = new System.Windows.Forms.GroupBox();
			this.safeNumericUpDown2 = new CharacterEditor.Forms.SafeNumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.safeNumericUpDown1 = new CharacterEditor.Forms.SafeNumericUpDown();
			this.labelItemModelId = new System.Windows.Forms.Label();
			this.labelPrefixId = new System.Windows.Forms.Label();
			this.comboBoxItemPrefixId = new System.Windows.Forms.ComboBox();
			this.groupBoxItemProperties = new System.Windows.Forms.GroupBox();
			this.groupBoxItemFlags = new System.Windows.Forms.GroupBox();
			this.checkBoxItemAdapted = new System.Windows.Forms.CheckBox();
			this.comboBoxItemRarity = new System.Windows.Forms.ComboBox();
			this.nudItemCount = new CharacterEditor.Forms.SafeNumericUpDown();
			this.labelItemRarity = new System.Windows.Forms.Label();
			this.labelItemCount = new System.Windows.Forms.Label();
			this.comboBoxItemMaterial = new System.Windows.Forms.ComboBox();
			this.labelMaterial = new System.Windows.Forms.Label();
			this.nudItemLevel = new CharacterEditor.Forms.SafeNumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.labelItemSubtype = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBoxItemSubtype = new System.Windows.Forms.ComboBox();
			this.comboBoxItemType = new System.Windows.Forms.ComboBox();
			this.tabControlInventory = new System.Windows.Forms.TabControl();
			this.tabPageEquipment = new System.Windows.Forms.TabPage();
			this.groupBoxCoins = new System.Windows.Forms.GroupBox();
			this.nudCoinsPlatinum = new CharacterEditor.Forms.SafeNumericUpDown();
			this.labelPlatinumCoins = new System.Windows.Forms.Label();
			this.nudCoinsCopper = new CharacterEditor.Forms.SafeNumericUpDown();
			this.nudCoinsSilver = new CharacterEditor.Forms.SafeNumericUpDown();
			this.nudCoinsGold = new CharacterEditor.Forms.SafeNumericUpDown();
			this.labelCoins = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label9 = new System.Windows.Forms.Label();
			this.tabControlEquipment = new System.Windows.Forms.TabControl();
			this.tabPageAbout = new System.Windows.Forms.TabPage();
			this.labelAboutEditorName = new System.Windows.Forms.Label();
			this.linkLabelX2048 = new System.Windows.Forms.LinkLabel();
			this.pictureBoxX2048 = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this.labelCopyright = new System.Windows.Forms.Label();
			this.buttonLoadNewCharacter = new System.Windows.Forms.Button();
			this.imageListInventory = new System.Windows.Forms.ImageList(this.components);
			this.safeNumericUpDown3 = new CharacterEditor.Forms.SafeNumericUpDown();
			this.safeNumericUpDown4 = new CharacterEditor.Forms.SafeNumericUpDown();
			this.safeNumericUpDown5 = new CharacterEditor.Forms.SafeNumericUpDown();
			this.safeNumericUpDown6 = new CharacterEditor.Forms.SafeNumericUpDown();
			this.safeNumericUpDown7 = new CharacterEditor.Forms.SafeNumericUpDown();
			this.safeNumericUpDown8 = new CharacterEditor.Forms.SafeNumericUpDown();
			this.safeNumericUpDown9 = new CharacterEditor.Forms.SafeNumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
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
			this.groupBoxSkills.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudSailingSkillLevel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudSwimmingSkillLevel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudHangGlidingSkillLevel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudClimbingSkillLevel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudPetRidingSkillLevel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudPetMasterSkillLevel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudTierThreeSkillLevel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudTierTwoSkillLevel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudTierOneSkillLevel)).BeginInit();
			this.panelCharacterPreview.SuspendLayout();
			this.groupBoxCharacterInformation.SuspendLayout();
			this.tabPagePets.SuspendLayout();
			this.panelPetPreview.SuspendLayout();
			this.tabPageInventory.SuspendLayout();
			this.groupBoxItemStats.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.safeNumericUpDown2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.safeNumericUpDown1)).BeginInit();
			this.groupBoxItemProperties.SuspendLayout();
			this.groupBoxItemFlags.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudItemCount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudItemLevel)).BeginInit();
			this.tabPageEquipment.SuspendLayout();
			this.groupBoxCoins.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudCoinsPlatinum)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudCoinsCopper)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudCoinsSilver)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudCoinsGold)).BeginInit();
			this.panel2.SuspendLayout();
			this.tabPageAbout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxX2048)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.safeNumericUpDown3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.safeNumericUpDown4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.safeNumericUpDown5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.safeNumericUpDown6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.safeNumericUpDown7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.safeNumericUpDown8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.safeNumericUpDown9)).BeginInit();
			this.SuspendLayout();
			// 
			// textBoxName
			// 
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
			this.buttonHairColor.Location = new System.Drawing.Point(141, 127);
			this.buttonHairColor.Name = "buttonHairColor";
			this.buttonHairColor.Size = new System.Drawing.Size(16, 16);
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
			this.nudHair.Maximum = new decimal(new int[] {
            102,
            0,
            0,
            0});
			this.nudHair.Name = "nudHair";
			this.nudHair.Size = new System.Drawing.Size(121, 20);
			this.nudHair.TabIndex = 6;
			this.nudHair.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
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
			this.nudFace.Maximum = new decimal(new int[] {
            101,
            0,
            0,
            0});
			this.nudFace.Name = "nudFace";
			this.nudFace.Size = new System.Drawing.Size(121, 20);
			this.nudFace.TabIndex = 4;
			this.nudFace.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
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
            2147483647,
            0,
            0,
            0});
			this.nudLevel.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
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
            2147483647,
            0,
            0,
            0});
			this.nudExperience.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
			this.nudExperience.Name = "nudExperience";
			this.nudExperience.Size = new System.Drawing.Size(121, 20);
			this.nudExperience.TabIndex = 5;
			this.nudExperience.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
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
			this.groupBoxPetInformation.Controls.Add(this.labelPetName);
			this.groupBoxPetInformation.Controls.Add(this.textBoxPetName);
			this.groupBoxPetInformation.Controls.Add(this.labelPetLevel);
			this.groupBoxPetInformation.Controls.Add(this.nudPetLevel);
			this.groupBoxPetInformation.Controls.Add(this.labelPetXP);
			this.groupBoxPetInformation.Controls.Add(this.nudPetExperience);
			this.groupBoxPetInformation.Controls.Add(this.comboBoxPetKind);
			this.groupBoxPetInformation.Controls.Add(this.labelPetKind);
			this.groupBoxPetInformation.Location = new System.Drawing.Point(6, 6);
			this.groupBoxPetInformation.Name = "groupBoxPetInformation";
			this.groupBoxPetInformation.Size = new System.Drawing.Size(268, 134);
			this.groupBoxPetInformation.TabIndex = 7;
			this.groupBoxPetInformation.TabStop = false;
			this.groupBoxPetInformation.Text = "Pet Information";
			// 
			// labelPetName
			// 
			this.labelPetName.AutoSize = true;
			this.labelPetName.Location = new System.Drawing.Point(6, 22);
			this.labelPetName.Name = "labelPetName";
			this.labelPetName.Size = new System.Drawing.Size(38, 13);
			this.labelPetName.TabIndex = 7;
			this.labelPetName.Text = "Name:";
			// 
			// textBoxPetName
			// 
			this.textBoxPetName.Location = new System.Drawing.Point(141, 19);
			this.textBoxPetName.MaxLength = 15;
			this.textBoxPetName.Name = "textBoxPetName";
			this.textBoxPetName.Size = new System.Drawing.Size(121, 20);
			this.textBoxPetName.TabIndex = 6;
			// 
			// labelPetLevel
			// 
			this.labelPetLevel.AutoSize = true;
			this.labelPetLevel.Location = new System.Drawing.Point(6, 74);
			this.labelPetLevel.Name = "labelPetLevel";
			this.labelPetLevel.Size = new System.Drawing.Size(36, 13);
			this.labelPetLevel.TabIndex = 5;
			this.labelPetLevel.Text = "Level:";
			// 
			// nudPetLevel
			// 
			this.nudPetLevel.Location = new System.Drawing.Point(141, 72);
			this.nudPetLevel.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
			this.nudPetLevel.Minimum = new decimal(new int[] {
            32768,
            0,
            0,
            -2147483648});
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
			this.labelPetXP.Location = new System.Drawing.Point(6, 100);
			this.labelPetXP.Name = "labelPetXP";
			this.labelPetXP.Size = new System.Drawing.Size(63, 13);
			this.labelPetXP.TabIndex = 3;
			this.labelPetXP.Text = "Experience:";
			// 
			// nudPetExperience
			// 
			this.nudPetExperience.Location = new System.Drawing.Point(141, 98);
			this.nudPetExperience.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			this.nudPetExperience.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
			this.nudPetExperience.Name = "nudPetExperience";
			this.nudPetExperience.Size = new System.Drawing.Size(121, 20);
			this.nudPetExperience.TabIndex = 2;
			this.nudPetExperience.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
			// 
			// comboBoxPetKind
			// 
			this.comboBoxPetKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxPetKind.FormattingEnabled = true;
			this.comboBoxPetKind.Location = new System.Drawing.Point(141, 45);
			this.comboBoxPetKind.Name = "comboBoxPetKind";
			this.comboBoxPetKind.Size = new System.Drawing.Size(121, 21);
			this.comboBoxPetKind.TabIndex = 1;
			// 
			// labelPetKind
			// 
			this.labelPetKind.AutoSize = true;
			this.labelPetKind.Location = new System.Drawing.Point(6, 48);
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
			this.tabControlWorkspace.Controls.Add(this.tabPageEquipment);
			this.tabControlWorkspace.Controls.Add(this.tabPageAbout);
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
			this.groupBoxSkills.Controls.Add(this.labelClimbingSkillLevel);
			this.groupBoxSkills.Controls.Add(this.labelPetRidingSkillLevel);
			this.groupBoxSkills.Controls.Add(this.labelPetMasterSkillLevel);
			this.groupBoxSkills.Controls.Add(this.labelSailingSkillLevel);
			this.groupBoxSkills.Controls.Add(this.labelSwimmingSkillLevel);
			this.groupBoxSkills.Controls.Add(this.labelHangGlidingSkillLevel);
			this.groupBoxSkills.Controls.Add(this.labelTierThreeSkillLevel);
			this.groupBoxSkills.Controls.Add(this.labelTierTwoSkillLevel);
			this.groupBoxSkills.Controls.Add(this.labelTierOneSkillLevel);
			this.groupBoxSkills.Controls.Add(this.nudSailingSkillLevel);
			this.groupBoxSkills.Controls.Add(this.nudSwimmingSkillLevel);
			this.groupBoxSkills.Controls.Add(this.nudHangGlidingSkillLevel);
			this.groupBoxSkills.Controls.Add(this.nudClimbingSkillLevel);
			this.groupBoxSkills.Controls.Add(this.nudPetRidingSkillLevel);
			this.groupBoxSkills.Controls.Add(this.nudPetMasterSkillLevel);
			this.groupBoxSkills.Controls.Add(this.nudTierThreeSkillLevel);
			this.groupBoxSkills.Controls.Add(this.nudTierTwoSkillLevel);
			this.groupBoxSkills.Controls.Add(this.nudTierOneSkillLevel);
			this.groupBoxSkills.Location = new System.Drawing.Point(6, 203);
			this.groupBoxSkills.Name = "groupBoxSkills";
			this.groupBoxSkills.Size = new System.Drawing.Size(542, 154);
			this.groupBoxSkills.TabIndex = 8;
			this.groupBoxSkills.TabStop = false;
			this.groupBoxSkills.Text = "Skills";
			// 
			// labelClimbingSkillLevel
			// 
			this.labelClimbingSkillLevel.AutoSize = true;
			this.labelClimbingSkillLevel.Location = new System.Drawing.Point(280, 21);
			this.labelClimbingSkillLevel.Name = "labelClimbingSkillLevel";
			this.labelClimbingSkillLevel.Size = new System.Drawing.Size(49, 13);
			this.labelClimbingSkillLevel.TabIndex = 17;
			this.labelClimbingSkillLevel.Text = "Climbing:";
			// 
			// labelPetRidingSkillLevel
			// 
			this.labelPetRidingSkillLevel.AutoSize = true;
			this.labelPetRidingSkillLevel.Location = new System.Drawing.Point(6, 125);
			this.labelPetRidingSkillLevel.Name = "labelPetRidingSkillLevel";
			this.labelPetRidingSkillLevel.Size = new System.Drawing.Size(59, 13);
			this.labelPetRidingSkillLevel.TabIndex = 16;
			this.labelPetRidingSkillLevel.Text = "Pet Riding:";
			// 
			// labelPetMasterSkillLevel
			// 
			this.labelPetMasterSkillLevel.AutoSize = true;
			this.labelPetMasterSkillLevel.Location = new System.Drawing.Point(6, 99);
			this.labelPetMasterSkillLevel.Name = "labelPetMasterSkillLevel";
			this.labelPetMasterSkillLevel.Size = new System.Drawing.Size(61, 13);
			this.labelPetMasterSkillLevel.TabIndex = 15;
			this.labelPetMasterSkillLevel.Text = "Pet Master:";
			// 
			// labelSailingSkillLevel
			// 
			this.labelSailingSkillLevel.AutoSize = true;
			this.labelSailingSkillLevel.Location = new System.Drawing.Point(280, 99);
			this.labelSailingSkillLevel.Name = "labelSailingSkillLevel";
			this.labelSailingSkillLevel.Size = new System.Drawing.Size(41, 13);
			this.labelSailingSkillLevel.TabIndex = 14;
			this.labelSailingSkillLevel.Text = "Sailing:";
			// 
			// labelSwimmingSkillLevel
			// 
			this.labelSwimmingSkillLevel.AutoSize = true;
			this.labelSwimmingSkillLevel.Location = new System.Drawing.Point(280, 73);
			this.labelSwimmingSkillLevel.Name = "labelSwimmingSkillLevel";
			this.labelSwimmingSkillLevel.Size = new System.Drawing.Size(57, 13);
			this.labelSwimmingSkillLevel.TabIndex = 13;
			this.labelSwimmingSkillLevel.Text = "Swimming:";
			// 
			// labelHangGlidingSkillLevel
			// 
			this.labelHangGlidingSkillLevel.AutoSize = true;
			this.labelHangGlidingSkillLevel.Location = new System.Drawing.Point(280, 47);
			this.labelHangGlidingSkillLevel.Name = "labelHangGlidingSkillLevel";
			this.labelHangGlidingSkillLevel.Size = new System.Drawing.Size(71, 13);
			this.labelHangGlidingSkillLevel.TabIndex = 12;
			this.labelHangGlidingSkillLevel.Text = "Hang Gliding:";
			// 
			// labelTierThreeSkillLevel
			// 
			this.labelTierThreeSkillLevel.AutoSize = true;
			this.labelTierThreeSkillLevel.Location = new System.Drawing.Point(6, 73);
			this.labelTierThreeSkillLevel.Name = "labelTierThreeSkillLevel";
			this.labelTierThreeSkillLevel.Size = new System.Drawing.Size(59, 13);
			this.labelTierThreeSkillLevel.TabIndex = 11;
			this.labelTierThreeSkillLevel.Text = "Tier Three:";
			// 
			// labelTierTwoSkillLevel
			// 
			this.labelTierTwoSkillLevel.AutoSize = true;
			this.labelTierTwoSkillLevel.Location = new System.Drawing.Point(6, 47);
			this.labelTierTwoSkillLevel.Name = "labelTierTwoSkillLevel";
			this.labelTierTwoSkillLevel.Size = new System.Drawing.Size(52, 13);
			this.labelTierTwoSkillLevel.TabIndex = 10;
			this.labelTierTwoSkillLevel.Text = "Tier Two:";
			// 
			// labelTierOneSkillLevel
			// 
			this.labelTierOneSkillLevel.AutoSize = true;
			this.labelTierOneSkillLevel.Location = new System.Drawing.Point(6, 21);
			this.labelTierOneSkillLevel.Name = "labelTierOneSkillLevel";
			this.labelTierOneSkillLevel.Size = new System.Drawing.Size(51, 13);
			this.labelTierOneSkillLevel.TabIndex = 9;
			this.labelTierOneSkillLevel.Text = "Tier One:";
			// 
			// nudSailingSkillLevel
			// 
			this.nudSailingSkillLevel.Location = new System.Drawing.Point(415, 97);
			this.nudSailingSkillLevel.Maximum = new decimal(new int[] {
            238609294,
            0,
            0,
            0});
			this.nudSailingSkillLevel.Name = "nudSailingSkillLevel";
			this.nudSailingSkillLevel.Size = new System.Drawing.Size(121, 20);
			this.nudSailingSkillLevel.TabIndex = 8;
			this.nudSailingSkillLevel.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
			// 
			// nudSwimmingSkillLevel
			// 
			this.nudSwimmingSkillLevel.Location = new System.Drawing.Point(415, 71);
			this.nudSwimmingSkillLevel.Maximum = new decimal(new int[] {
            238609294,
            0,
            0,
            0});
			this.nudSwimmingSkillLevel.Name = "nudSwimmingSkillLevel";
			this.nudSwimmingSkillLevel.Size = new System.Drawing.Size(121, 20);
			this.nudSwimmingSkillLevel.TabIndex = 7;
			this.nudSwimmingSkillLevel.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
			// 
			// nudHangGlidingSkillLevel
			// 
			this.nudHangGlidingSkillLevel.Location = new System.Drawing.Point(415, 45);
			this.nudHangGlidingSkillLevel.Maximum = new decimal(new int[] {
            238609294,
            0,
            0,
            0});
			this.nudHangGlidingSkillLevel.Name = "nudHangGlidingSkillLevel";
			this.nudHangGlidingSkillLevel.Size = new System.Drawing.Size(121, 20);
			this.nudHangGlidingSkillLevel.TabIndex = 6;
			this.nudHangGlidingSkillLevel.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
			// 
			// nudClimbingSkillLevel
			// 
			this.nudClimbingSkillLevel.Location = new System.Drawing.Point(415, 19);
			this.nudClimbingSkillLevel.Maximum = new decimal(new int[] {
            238609294,
            0,
            0,
            0});
			this.nudClimbingSkillLevel.Name = "nudClimbingSkillLevel";
			this.nudClimbingSkillLevel.Size = new System.Drawing.Size(121, 20);
			this.nudClimbingSkillLevel.TabIndex = 5;
			this.nudClimbingSkillLevel.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
			// 
			// nudPetRidingSkillLevel
			// 
			this.nudPetRidingSkillLevel.Location = new System.Drawing.Point(141, 123);
			this.nudPetRidingSkillLevel.Maximum = new decimal(new int[] {
            238609294,
            0,
            0,
            0});
			this.nudPetRidingSkillLevel.Name = "nudPetRidingSkillLevel";
			this.nudPetRidingSkillLevel.Size = new System.Drawing.Size(121, 20);
			this.nudPetRidingSkillLevel.TabIndex = 4;
			this.nudPetRidingSkillLevel.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
			// 
			// nudPetMasterSkillLevel
			// 
			this.nudPetMasterSkillLevel.Location = new System.Drawing.Point(141, 97);
			this.nudPetMasterSkillLevel.Maximum = new decimal(new int[] {
            238609294,
            0,
            0,
            0});
			this.nudPetMasterSkillLevel.Name = "nudPetMasterSkillLevel";
			this.nudPetMasterSkillLevel.Size = new System.Drawing.Size(121, 20);
			this.nudPetMasterSkillLevel.TabIndex = 3;
			this.nudPetMasterSkillLevel.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
			// 
			// nudTierThreeSkillLevel
			// 
			this.nudTierThreeSkillLevel.Location = new System.Drawing.Point(141, 71);
			this.nudTierThreeSkillLevel.Maximum = new decimal(new int[] {
            238609294,
            0,
            0,
            0});
			this.nudTierThreeSkillLevel.Name = "nudTierThreeSkillLevel";
			this.nudTierThreeSkillLevel.Size = new System.Drawing.Size(121, 20);
			this.nudTierThreeSkillLevel.TabIndex = 2;
			this.nudTierThreeSkillLevel.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
			// 
			// nudTierTwoSkillLevel
			// 
			this.nudTierTwoSkillLevel.Location = new System.Drawing.Point(141, 45);
			this.nudTierTwoSkillLevel.Maximum = new decimal(new int[] {
            238609294,
            0,
            0,
            0});
			this.nudTierTwoSkillLevel.Name = "nudTierTwoSkillLevel";
			this.nudTierTwoSkillLevel.Size = new System.Drawing.Size(121, 20);
			this.nudTierTwoSkillLevel.TabIndex = 1;
			this.nudTierTwoSkillLevel.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
			// 
			// nudTierOneSkillLevel
			// 
			this.nudTierOneSkillLevel.Location = new System.Drawing.Point(141, 19);
			this.nudTierOneSkillLevel.Maximum = new decimal(new int[] {
            238609294,
            0,
            0,
            0});
			this.nudTierOneSkillLevel.Name = "nudTierOneSkillLevel";
			this.nudTierOneSkillLevel.Size = new System.Drawing.Size(121, 20);
			this.nudTierOneSkillLevel.TabIndex = 0;
			this.nudTierOneSkillLevel.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
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
			this.tabPagePets.Text = "Pet";
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
			this.tabPageInventory.Controls.Add(this.groupBoxItemStats);
			this.tabPageInventory.Controls.Add(this.groupBoxItemProperties);
			this.tabPageInventory.Controls.Add(this.nudItemCount);
			this.tabPageInventory.Controls.Add(this.tabControlInventory);
			this.tabPageInventory.Controls.Add(this.labelItemCount);
			this.tabPageInventory.Location = new System.Drawing.Point(4, 22);
			this.tabPageInventory.Name = "tabPageInventory";
			this.tabPageInventory.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageInventory.Size = new System.Drawing.Size(696, 363);
			this.tabPageInventory.TabIndex = 2;
			this.tabPageInventory.Text = "Inventory";
			this.tabPageInventory.UseVisualStyleBackColor = true;
			// 
			// groupBoxItemStats
			// 
			this.groupBoxItemStats.Controls.Add(this.label11);
			this.groupBoxItemStats.Controls.Add(this.label10);
			this.groupBoxItemStats.Controls.Add(this.label8);
			this.groupBoxItemStats.Controls.Add(this.label7);
			this.groupBoxItemStats.Controls.Add(this.label6);
			this.groupBoxItemStats.Controls.Add(this.label1);
			this.groupBoxItemStats.Controls.Add(this.safeNumericUpDown9);
			this.groupBoxItemStats.Controls.Add(this.safeNumericUpDown8);
			this.groupBoxItemStats.Controls.Add(this.safeNumericUpDown7);
			this.groupBoxItemStats.Controls.Add(this.safeNumericUpDown6);
			this.groupBoxItemStats.Controls.Add(this.safeNumericUpDown5);
			this.groupBoxItemStats.Controls.Add(this.safeNumericUpDown4);
			this.groupBoxItemStats.Controls.Add(this.safeNumericUpDown3);
			this.groupBoxItemStats.Controls.Add(this.safeNumericUpDown2);
			this.groupBoxItemStats.Controls.Add(this.label5);
			this.groupBoxItemStats.Controls.Add(this.safeNumericUpDown1);
			this.groupBoxItemStats.Controls.Add(this.labelItemModelId);
			this.groupBoxItemStats.Controls.Add(this.labelPrefixId);
			this.groupBoxItemStats.Controls.Add(this.comboBoxItemPrefixId);
			this.groupBoxItemStats.Location = new System.Drawing.Point(554, 32);
			this.groupBoxItemStats.Name = "groupBoxItemStats";
			this.groupBoxItemStats.Size = new System.Drawing.Size(136, 325);
			this.groupBoxItemStats.TabIndex = 12;
			this.groupBoxItemStats.TabStop = false;
			this.groupBoxItemStats.Text = "Item Stats";
			// 
			// safeNumericUpDown2
			// 
			this.safeNumericUpDown2.Location = new System.Drawing.Point(6, 111);
			this.safeNumericUpDown2.Name = "safeNumericUpDown2";
			this.safeNumericUpDown2.Size = new System.Drawing.Size(124, 20);
			this.safeNumericUpDown2.TabIndex = 9;
			this.safeNumericUpDown2.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 95);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(52, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Effect ID:";
			// 
			// safeNumericUpDown1
			// 
			this.safeNumericUpDown1.Location = new System.Drawing.Point(6, 72);
			this.safeNumericUpDown1.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
			this.safeNumericUpDown1.Name = "safeNumericUpDown1";
			this.safeNumericUpDown1.Size = new System.Drawing.Size(124, 20);
			this.safeNumericUpDown1.TabIndex = 7;
			this.safeNumericUpDown1.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
			// 
			// labelItemModelId
			// 
			this.labelItemModelId.AutoSize = true;
			this.labelItemModelId.Location = new System.Drawing.Point(6, 56);
			this.labelItemModelId.Name = "labelItemModelId";
			this.labelItemModelId.Size = new System.Drawing.Size(53, 13);
			this.labelItemModelId.TabIndex = 6;
			this.labelItemModelId.Text = "Model ID:";
			// 
			// labelPrefixId
			// 
			this.labelPrefixId.AutoSize = true;
			this.labelPrefixId.Location = new System.Drawing.Point(6, 16);
			this.labelPrefixId.Name = "labelPrefixId";
			this.labelPrefixId.Size = new System.Drawing.Size(50, 13);
			this.labelPrefixId.TabIndex = 4;
			this.labelPrefixId.Text = "Prefix ID:";
			// 
			// comboBoxItemPrefixId
			// 
			this.comboBoxItemPrefixId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxItemPrefixId.FormattingEnabled = true;
			this.comboBoxItemPrefixId.Location = new System.Drawing.Point(6, 32);
			this.comboBoxItemPrefixId.Name = "comboBoxItemPrefixId";
			this.comboBoxItemPrefixId.Size = new System.Drawing.Size(124, 21);
			this.comboBoxItemPrefixId.TabIndex = 5;
			this.comboBoxItemPrefixId.SelectedIndexChanged += new System.EventHandler(this.ComboBoxItemModifierSelectedIndexChanged);
			// 
			// groupBoxItemProperties
			// 
			this.groupBoxItemProperties.Controls.Add(this.groupBoxItemFlags);
			this.groupBoxItemProperties.Controls.Add(this.comboBoxItemRarity);
			this.groupBoxItemProperties.Controls.Add(this.labelItemRarity);
			this.groupBoxItemProperties.Controls.Add(this.comboBoxItemMaterial);
			this.groupBoxItemProperties.Controls.Add(this.labelMaterial);
			this.groupBoxItemProperties.Controls.Add(this.nudItemLevel);
			this.groupBoxItemProperties.Controls.Add(this.label3);
			this.groupBoxItemProperties.Controls.Add(this.labelItemSubtype);
			this.groupBoxItemProperties.Controls.Add(this.label2);
			this.groupBoxItemProperties.Controls.Add(this.comboBoxItemSubtype);
			this.groupBoxItemProperties.Controls.Add(this.comboBoxItemType);
			this.groupBoxItemProperties.Location = new System.Drawing.Point(6, 239);
			this.groupBoxItemProperties.Name = "groupBoxItemProperties";
			this.groupBoxItemProperties.Size = new System.Drawing.Size(542, 118);
			this.groupBoxItemProperties.TabIndex = 11;
			this.groupBoxItemProperties.TabStop = false;
			this.groupBoxItemProperties.Text = "Item";
			// 
			// groupBoxItemFlags
			// 
			this.groupBoxItemFlags.Controls.Add(this.checkBoxItemAdapted);
			this.groupBoxItemFlags.Location = new System.Drawing.Point(396, 19);
			this.groupBoxItemFlags.Name = "groupBoxItemFlags";
			this.groupBoxItemFlags.Size = new System.Drawing.Size(140, 93);
			this.groupBoxItemFlags.TabIndex = 15;
			this.groupBoxItemFlags.TabStop = false;
			this.groupBoxItemFlags.Text = "Item Flags";
			// 
			// checkBoxItemAdapted
			// 
			this.checkBoxItemAdapted.AutoSize = true;
			this.checkBoxItemAdapted.Location = new System.Drawing.Point(6, 19);
			this.checkBoxItemAdapted.Name = "checkBoxItemAdapted";
			this.checkBoxItemAdapted.Size = new System.Drawing.Size(66, 17);
			this.checkBoxItemAdapted.TabIndex = 0;
			this.checkBoxItemAdapted.Text = "Adapted";
			this.checkBoxItemAdapted.UseVisualStyleBackColor = true;
			this.checkBoxItemAdapted.CheckedChanged += new System.EventHandler(this.CheckBoxItemAdaptedCheckedChanged);
			// 
			// comboBoxItemRarity
			// 
			this.comboBoxItemRarity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxItemRarity.FormattingEnabled = true;
			this.comboBoxItemRarity.Location = new System.Drawing.Point(136, 76);
			this.comboBoxItemRarity.Name = "comboBoxItemRarity";
			this.comboBoxItemRarity.Size = new System.Drawing.Size(124, 21);
			this.comboBoxItemRarity.TabIndex = 14;
			this.comboBoxItemRarity.SelectedIndexChanged += new System.EventHandler(this.ComboBoxItemRaritySelectedIndexChanged);
			// 
			// nudItemCount
			// 
			this.nudItemCount.Location = new System.Drawing.Point(595, 6);
			this.nudItemCount.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			this.nudItemCount.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
			this.nudItemCount.Name = "nudItemCount";
			this.nudItemCount.Size = new System.Drawing.Size(98, 20);
			this.nudItemCount.TabIndex = 13;
			this.nudItemCount.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.nudItemCount.ValueChanged += new System.EventHandler(this.NudItemCountValueChanged);
			// 
			// labelItemRarity
			// 
			this.labelItemRarity.AutoSize = true;
			this.labelItemRarity.Location = new System.Drawing.Point(133, 60);
			this.labelItemRarity.Name = "labelItemRarity";
			this.labelItemRarity.Size = new System.Drawing.Size(37, 13);
			this.labelItemRarity.TabIndex = 10;
			this.labelItemRarity.Text = "Rarity:";
			// 
			// labelItemCount
			// 
			this.labelItemCount.AutoSize = true;
			this.labelItemCount.Location = new System.Drawing.Point(551, 8);
			this.labelItemCount.Name = "labelItemCount";
			this.labelItemCount.Size = new System.Drawing.Size(38, 13);
			this.labelItemCount.TabIndex = 12;
			this.labelItemCount.Text = "Count:";
			// 
			// comboBoxItemMaterial
			// 
			this.comboBoxItemMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxItemMaterial.FormattingEnabled = true;
			this.comboBoxItemMaterial.Location = new System.Drawing.Point(136, 32);
			this.comboBoxItemMaterial.Name = "comboBoxItemMaterial";
			this.comboBoxItemMaterial.Size = new System.Drawing.Size(124, 21);
			this.comboBoxItemMaterial.TabIndex = 9;
			this.comboBoxItemMaterial.SelectedIndexChanged += new System.EventHandler(this.ComboBoxItemMaterialSelectedIndexChanged);
			// 
			// labelMaterial
			// 
			this.labelMaterial.AutoSize = true;
			this.labelMaterial.Location = new System.Drawing.Point(133, 16);
			this.labelMaterial.Name = "labelMaterial";
			this.labelMaterial.Size = new System.Drawing.Size(47, 13);
			this.labelMaterial.TabIndex = 8;
			this.labelMaterial.Text = "Material:";
			// 
			// nudItemLevel
			// 
			this.nudItemLevel.Location = new System.Drawing.Point(266, 32);
			this.nudItemLevel.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
			this.nudItemLevel.Minimum = new decimal(new int[] {
            32768,
            0,
            0,
            -2147483648});
			this.nudItemLevel.Name = "nudItemLevel";
			this.nudItemLevel.Size = new System.Drawing.Size(124, 20);
			this.nudItemLevel.TabIndex = 7;
			this.nudItemLevel.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.nudItemLevel.ValueChanged += new System.EventHandler(this.NudItemLevelValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(263, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(36, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Level:";
			// 
			// labelItemSubtype
			// 
			this.labelItemSubtype.AutoSize = true;
			this.labelItemSubtype.Location = new System.Drawing.Point(3, 60);
			this.labelItemSubtype.Name = "labelItemSubtype";
			this.labelItemSubtype.Size = new System.Drawing.Size(49, 13);
			this.labelItemSubtype.TabIndex = 3;
			this.labelItemSubtype.Text = "Subtype:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Type:";
			// 
			// comboBoxItemSubtype
			// 
			this.comboBoxItemSubtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxItemSubtype.FormattingEnabled = true;
			this.comboBoxItemSubtype.Location = new System.Drawing.Point(6, 76);
			this.comboBoxItemSubtype.Name = "comboBoxItemSubtype";
			this.comboBoxItemSubtype.Size = new System.Drawing.Size(124, 21);
			this.comboBoxItemSubtype.TabIndex = 1;
			this.comboBoxItemSubtype.SelectedIndexChanged += new System.EventHandler(this.ComboBoxItemSubtypeSelectedIndexChanged);
			// 
			// comboBoxItemType
			// 
			this.comboBoxItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxItemType.FormattingEnabled = true;
			this.comboBoxItemType.Location = new System.Drawing.Point(6, 32);
			this.comboBoxItemType.Name = "comboBoxItemType";
			this.comboBoxItemType.Size = new System.Drawing.Size(124, 21);
			this.comboBoxItemType.TabIndex = 0;
			this.comboBoxItemType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxItemTypeSelectedIndexChanged);
			// 
			// tabControlInventory
			// 
			this.tabControlInventory.Location = new System.Drawing.Point(6, 6);
			this.tabControlInventory.Name = "tabControlInventory";
			this.tabControlInventory.SelectedIndex = 0;
			this.tabControlInventory.Size = new System.Drawing.Size(542, 227);
			this.tabControlInventory.TabIndex = 10;
			// 
			// tabPageEquipment
			// 
			this.tabPageEquipment.Controls.Add(this.groupBoxCoins);
			this.tabPageEquipment.Controls.Add(this.panel2);
			this.tabPageEquipment.Controls.Add(this.tabControlEquipment);
			this.tabPageEquipment.Location = new System.Drawing.Point(4, 22);
			this.tabPageEquipment.Name = "tabPageEquipment";
			this.tabPageEquipment.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageEquipment.Size = new System.Drawing.Size(696, 363);
			this.tabPageEquipment.TabIndex = 3;
			this.tabPageEquipment.Text = "Equipment";
			this.tabPageEquipment.UseVisualStyleBackColor = true;
			// 
			// groupBoxCoins
			// 
			this.groupBoxCoins.Controls.Add(this.nudCoinsPlatinum);
			this.groupBoxCoins.Controls.Add(this.labelPlatinumCoins);
			this.groupBoxCoins.Controls.Add(this.nudCoinsCopper);
			this.groupBoxCoins.Controls.Add(this.nudCoinsSilver);
			this.groupBoxCoins.Controls.Add(this.nudCoinsGold);
			this.groupBoxCoins.Controls.Add(this.labelCoins);
			this.groupBoxCoins.Location = new System.Drawing.Point(8, 239);
			this.groupBoxCoins.Name = "groupBoxCoins";
			this.groupBoxCoins.Size = new System.Drawing.Size(540, 118);
			this.groupBoxCoins.TabIndex = 14;
			this.groupBoxCoins.TabStop = false;
			this.groupBoxCoins.Text = "Coins";
			// 
			// nudCoinsPlatinum
			// 
			this.nudCoinsPlatinum.Location = new System.Drawing.Point(6, 71);
			this.nudCoinsPlatinum.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			this.nudCoinsPlatinum.Name = "nudCoinsPlatinum";
			this.nudCoinsPlatinum.Size = new System.Drawing.Size(124, 20);
			this.nudCoinsPlatinum.TabIndex = 5;
			this.nudCoinsPlatinum.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
			// 
			// labelPlatinumCoins
			// 
			this.labelPlatinumCoins.AutoSize = true;
			this.labelPlatinumCoins.Location = new System.Drawing.Point(6, 55);
			this.labelPlatinumCoins.Name = "labelPlatinumCoins";
			this.labelPlatinumCoins.Size = new System.Drawing.Size(79, 13);
			this.labelPlatinumCoins.TabIndex = 4;
			this.labelPlatinumCoins.Text = "Platinum Coins:";
			// 
			// nudCoinsCopper
			// 
			this.nudCoinsCopper.Location = new System.Drawing.Point(92, 32);
			this.nudCoinsCopper.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
			this.nudCoinsCopper.Name = "nudCoinsCopper";
			this.nudCoinsCopper.Size = new System.Drawing.Size(38, 20);
			this.nudCoinsCopper.TabIndex = 3;
			this.nudCoinsCopper.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
			// 
			// nudCoinsSilver
			// 
			this.nudCoinsSilver.Location = new System.Drawing.Point(49, 32);
			this.nudCoinsSilver.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
			this.nudCoinsSilver.Name = "nudCoinsSilver";
			this.nudCoinsSilver.Size = new System.Drawing.Size(37, 20);
			this.nudCoinsSilver.TabIndex = 2;
			this.nudCoinsSilver.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
			// 
			// nudCoinsGold
			// 
			this.nudCoinsGold.Location = new System.Drawing.Point(6, 32);
			this.nudCoinsGold.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
			this.nudCoinsGold.Name = "nudCoinsGold";
			this.nudCoinsGold.Size = new System.Drawing.Size(37, 20);
			this.nudCoinsGold.TabIndex = 1;
			this.nudCoinsGold.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
			// 
			// labelCoins
			// 
			this.labelCoins.AutoSize = true;
			this.labelCoins.Location = new System.Drawing.Point(6, 16);
			this.labelCoins.Name = "labelCoins";
			this.labelCoins.Size = new System.Drawing.Size(36, 13);
			this.labelCoins.TabIndex = 0;
			this.labelCoins.Text = "Coins:";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.DarkGray;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.label9);
			this.panel2.Location = new System.Drawing.Point(554, 6);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(136, 136);
			this.panel2.TabIndex = 13;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label9.ForeColor = System.Drawing.Color.White;
			this.label9.Location = new System.Drawing.Point(0, 0);
			this.label9.Name = "label9";
			this.label9.Padding = new System.Windows.Forms.Padding(9, 60, 9, 60);
			this.label9.Size = new System.Drawing.Size(133, 133);
			this.label9.TabIndex = 0;
			this.label9.Text = "Inventory Item Preview";
			// 
			// tabControlEquipment
			// 
			this.tabControlEquipment.Location = new System.Drawing.Point(6, 6);
			this.tabControlEquipment.Name = "tabControlEquipment";
			this.tabControlEquipment.SelectedIndex = 0;
			this.tabControlEquipment.Size = new System.Drawing.Size(542, 227);
			this.tabControlEquipment.TabIndex = 11;
			// 
			// tabPageAbout
			// 
			this.tabPageAbout.Controls.Add(this.labelAboutEditorName);
			this.tabPageAbout.Controls.Add(this.linkLabelX2048);
			this.tabPageAbout.Controls.Add(this.pictureBoxX2048);
			this.tabPageAbout.Controls.Add(this.label4);
			this.tabPageAbout.Controls.Add(this.labelCopyright);
			this.tabPageAbout.Location = new System.Drawing.Point(4, 22);
			this.tabPageAbout.Name = "tabPageAbout";
			this.tabPageAbout.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageAbout.Size = new System.Drawing.Size(696, 363);
			this.tabPageAbout.TabIndex = 4;
			this.tabPageAbout.Text = "About";
			this.tabPageAbout.UseVisualStyleBackColor = true;
			// 
			// labelAboutEditorName
			// 
			this.labelAboutEditorName.AutoSize = true;
			this.labelAboutEditorName.Location = new System.Drawing.Point(6, 3);
			this.labelAboutEditorName.Name = "labelAboutEditorName";
			this.labelAboutEditorName.Size = new System.Drawing.Size(142, 13);
			this.labelAboutEditorName.TabIndex = 4;
			this.labelAboutEditorName.Text = "Cube World Character Editor";
			// 
			// linkLabelX2048
			// 
			this.linkLabelX2048.AutoSize = true;
			this.linkLabelX2048.Location = new System.Drawing.Point(6, 29);
			this.linkLabelX2048.Name = "linkLabelX2048";
			this.linkLabelX2048.Size = new System.Drawing.Size(86, 13);
			this.linkLabelX2048.TabIndex = 3;
			this.linkLabelX2048.TabStop = true;
			this.linkLabelX2048.Text = "www.x2048.com";
			this.linkLabelX2048.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelX2048LinkClicked);
			// 
			// pictureBoxX2048
			// 
			this.pictureBoxX2048.Image = global::CharacterEditor.Properties.Resources.x2048;
			this.pictureBoxX2048.Location = new System.Drawing.Point(434, 6);
			this.pictureBoxX2048.Name = "pictureBoxX2048";
			this.pictureBoxX2048.Size = new System.Drawing.Size(256, 256);
			this.pictureBoxX2048.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxX2048.TabIndex = 2;
			this.pictureBoxX2048.TabStop = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 53);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(311, 156);
			this.label4.TabIndex = 1;
			this.label4.Text = resources.GetString("label4.Text");
			// 
			// labelCopyright
			// 
			this.labelCopyright.AutoSize = true;
			this.labelCopyright.Location = new System.Drawing.Point(6, 16);
			this.labelCopyright.Name = "labelCopyright";
			this.labelCopyright.Size = new System.Drawing.Size(126, 13);
			this.labelCopyright.TabIndex = 0;
			this.labelCopyright.Text = "(C) 2013 Zachary Reedy ";
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
			// imageListInventory
			// 
			this.imageListInventory.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListInventory.ImageStream")));
			this.imageListInventory.TransparentColor = System.Drawing.Color.Transparent;
			this.imageListInventory.Images.SetKeyName(0, "ItemIcon.png");
			this.imageListInventory.Images.SetKeyName(1, "IconConsumable.png");
			this.imageListInventory.Images.SetKeyName(2, "IconRecipe.png");
			this.imageListInventory.Images.SetKeyName(3, "IconWeapon.png");
			this.imageListInventory.Images.SetKeyName(4, "IconChestArmor.png");
			this.imageListInventory.Images.SetKeyName(5, "IconGloves.png");
			this.imageListInventory.Images.SetKeyName(6, "IconBoots.png");
			this.imageListInventory.Images.SetKeyName(7, "IconShoulderArmor.png");
			this.imageListInventory.Images.SetKeyName(8, "IconAmulet.png");
			this.imageListInventory.Images.SetKeyName(9, "IconRing.png");
			this.imageListInventory.Images.SetKeyName(10, "IconBlock.png");
			this.imageListInventory.Images.SetKeyName(11, "IconItems.png");
			this.imageListInventory.Images.SetKeyName(12, "IconCoin.png");
			this.imageListInventory.Images.SetKeyName(13, "IconPlatinumCoin.png");
			this.imageListInventory.Images.SetKeyName(14, "IconLeftovers.png");
			this.imageListInventory.Images.SetKeyName(15, "IconBeak.png");
			this.imageListInventory.Images.SetKeyName(16, "IconPainting.png");
			this.imageListInventory.Images.SetKeyName(17, "IconVase.png");
			this.imageListInventory.Images.SetKeyName(18, "IconCandle.png");
			this.imageListInventory.Images.SetKeyName(19, "IconPet.png");
			this.imageListInventory.Images.SetKeyName(20, "IconPetFood.png");
			this.imageListInventory.Images.SetKeyName(21, "IconQuestItem.png");
			this.imageListInventory.Images.SetKeyName(22, "ItemIcon.png");
			this.imageListInventory.Images.SetKeyName(23, "IconTransportation.png");
			this.imageListInventory.Images.SetKeyName(24, "IconLamp.png");
			this.imageListInventory.Images.SetKeyName(25, "IconManaCube.png");
			// 
			// safeNumericUpDown3
			// 
			this.safeNumericUpDown3.Location = new System.Drawing.Point(61, 137);
			this.safeNumericUpDown3.Name = "safeNumericUpDown3";
			this.safeNumericUpDown3.Size = new System.Drawing.Size(69, 20);
			this.safeNumericUpDown3.TabIndex = 10;
			this.safeNumericUpDown3.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
			// 
			// safeNumericUpDown4
			// 
			this.safeNumericUpDown4.Location = new System.Drawing.Point(61, 163);
			this.safeNumericUpDown4.Name = "safeNumericUpDown4";
			this.safeNumericUpDown4.Size = new System.Drawing.Size(69, 20);
			this.safeNumericUpDown4.TabIndex = 11;
			this.safeNumericUpDown4.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
			// 
			// safeNumericUpDown5
			// 
			this.safeNumericUpDown5.Location = new System.Drawing.Point(61, 189);
			this.safeNumericUpDown5.Name = "safeNumericUpDown5";
			this.safeNumericUpDown5.Size = new System.Drawing.Size(69, 20);
			this.safeNumericUpDown5.TabIndex = 12;
			this.safeNumericUpDown5.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
			// 
			// safeNumericUpDown6
			// 
			this.safeNumericUpDown6.Location = new System.Drawing.Point(61, 215);
			this.safeNumericUpDown6.Name = "safeNumericUpDown6";
			this.safeNumericUpDown6.Size = new System.Drawing.Size(69, 20);
			this.safeNumericUpDown6.TabIndex = 13;
			this.safeNumericUpDown6.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
			// 
			// safeNumericUpDown7
			// 
			this.safeNumericUpDown7.Location = new System.Drawing.Point(61, 241);
			this.safeNumericUpDown7.Name = "safeNumericUpDown7";
			this.safeNumericUpDown7.Size = new System.Drawing.Size(69, 20);
			this.safeNumericUpDown7.TabIndex = 14;
			this.safeNumericUpDown7.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
			// 
			// safeNumericUpDown8
			// 
			this.safeNumericUpDown8.Location = new System.Drawing.Point(61, 267);
			this.safeNumericUpDown8.Name = "safeNumericUpDown8";
			this.safeNumericUpDown8.Size = new System.Drawing.Size(69, 20);
			this.safeNumericUpDown8.TabIndex = 15;
			this.safeNumericUpDown8.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
			// 
			// safeNumericUpDown9
			// 
			this.safeNumericUpDown9.Location = new System.Drawing.Point(61, 293);
			this.safeNumericUpDown9.Name = "safeNumericUpDown9";
			this.safeNumericUpDown9.Size = new System.Drawing.Size(69, 20);
			this.safeNumericUpDown9.TabIndex = 16;
			this.safeNumericUpDown9.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(30, 139);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(25, 13);
			this.label1.TabIndex = 17;
			this.label1.Text = "HP:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(18, 165);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(37, 13);
			this.label6.TabIndex = 18;
			this.label6.Text = "Armor:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(24, 191);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(31, 13);
			this.label7.TabIndex = 19;
			this.label7.Text = "Resi:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(12, 217);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(43, 13);
			this.label8.TabIndex = 20;
			this.label8.Text = "Tempo:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(30, 243);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(25, 13);
			this.label10.TabIndex = 21;
			this.label10.Text = "Crit:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(25, 269);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(30, 13);
			this.label11.TabIndex = 22;
			this.label11.Text = "Reg:";
			// 
			// Editor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(704, 442);
			this.Controls.Add(this.splitContainerWorkspace);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Editor";
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
			this.groupBoxSkills.ResumeLayout(false);
			this.groupBoxSkills.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudSailingSkillLevel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudSwimmingSkillLevel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudHangGlidingSkillLevel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudClimbingSkillLevel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudPetRidingSkillLevel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudPetMasterSkillLevel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudTierThreeSkillLevel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudTierTwoSkillLevel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudTierOneSkillLevel)).EndInit();
			this.panelCharacterPreview.ResumeLayout(false);
			this.panelCharacterPreview.PerformLayout();
			this.groupBoxCharacterInformation.ResumeLayout(false);
			this.groupBoxCharacterInformation.PerformLayout();
			this.tabPagePets.ResumeLayout(false);
			this.panelPetPreview.ResumeLayout(false);
			this.panelPetPreview.PerformLayout();
			this.tabPageInventory.ResumeLayout(false);
			this.tabPageInventory.PerformLayout();
			this.groupBoxItemStats.ResumeLayout(false);
			this.groupBoxItemStats.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.safeNumericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.safeNumericUpDown1)).EndInit();
			this.groupBoxItemProperties.ResumeLayout(false);
			this.groupBoxItemProperties.PerformLayout();
			this.groupBoxItemFlags.ResumeLayout(false);
			this.groupBoxItemFlags.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudItemCount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudItemLevel)).EndInit();
			this.tabPageEquipment.ResumeLayout(false);
			this.groupBoxCoins.ResumeLayout(false);
			this.groupBoxCoins.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudCoinsPlatinum)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudCoinsCopper)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudCoinsSilver)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudCoinsGold)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.tabPageAbout.ResumeLayout(false);
			this.tabPageAbout.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxX2048)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.safeNumericUpDown3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.safeNumericUpDown4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.safeNumericUpDown5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.safeNumericUpDown6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.safeNumericUpDown7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.safeNumericUpDown8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.safeNumericUpDown9)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.GroupBox groupBoxAppearance;
		private System.Windows.Forms.Label labelHair;
		private SafeNumericUpDown nudHair;
		private System.Windows.Forms.Label labelFace;
		private SafeNumericUpDown nudFace;
		private System.Windows.Forms.Label labelGender;
		private System.Windows.Forms.ComboBox comboBoxGender;
		private System.Windows.Forms.ComboBox comboBoxRace;
		private System.Windows.Forms.Label labelRace;
		private System.Windows.Forms.Button buttonHairColor;
		private System.Windows.Forms.Label labelHairColor;
		private System.Windows.Forms.Label labelLevel;
		private SafeNumericUpDown nudLevel;
		private System.Windows.Forms.Label labelExperience;
		private SafeNumericUpDown nudExperience;
		private System.Windows.Forms.Button buttonSaveCharacter;
		private System.Windows.Forms.GroupBox groupBoxPetInformation;
		private System.Windows.Forms.Label labelPetKind;
		private System.Windows.Forms.ComboBox comboBoxPetKind;
		private System.Windows.Forms.Label labelPetLevel;
		private SafeNumericUpDown nudPetLevel;
		private System.Windows.Forms.Label labelPetXP;
		private SafeNumericUpDown nudPetExperience;
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
		private System.Windows.Forms.Label labelClimbingSkillLevel;
		private System.Windows.Forms.Label labelPetRidingSkillLevel;
		private System.Windows.Forms.Label labelPetMasterSkillLevel;
		private System.Windows.Forms.Label labelSailingSkillLevel;
		private System.Windows.Forms.Label labelSwimmingSkillLevel;
		private System.Windows.Forms.Label labelHangGlidingSkillLevel;
		private System.Windows.Forms.Label labelTierThreeSkillLevel;
		private System.Windows.Forms.Label labelTierTwoSkillLevel;
		private System.Windows.Forms.Label labelTierOneSkillLevel;
		private SafeNumericUpDown nudSailingSkillLevel;
		private SafeNumericUpDown nudSwimmingSkillLevel;
		private SafeNumericUpDown nudHangGlidingSkillLevel;
		private SafeNumericUpDown nudClimbingSkillLevel;
		private SafeNumericUpDown nudPetRidingSkillLevel;
		private SafeNumericUpDown nudPetMasterSkillLevel;
		private SafeNumericUpDown nudTierThreeSkillLevel;
		private SafeNumericUpDown nudTierTwoSkillLevel;
		private SafeNumericUpDown nudTierOneSkillLevel;
		private System.Windows.Forms.Label labelPetName;
		private System.Windows.Forms.TextBox textBoxPetName;
		private System.Windows.Forms.TabControl tabControlInventory;
		private System.Windows.Forms.ImageList imageListInventory;
		private System.Windows.Forms.GroupBox groupBoxItemProperties;
		private SafeNumericUpDown nudItemLevel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBoxItemPrefixId;
		private System.Windows.Forms.Label labelPrefixId;
		private System.Windows.Forms.Label labelItemSubtype;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBoxItemSubtype;
		private System.Windows.Forms.ComboBox comboBoxItemType;
		private System.Windows.Forms.Label labelMaterial;
		private System.Windows.Forms.ComboBox comboBoxItemMaterial;
		private System.Windows.Forms.TabPage tabPageEquipment;
		private System.Windows.Forms.GroupBox groupBoxCoins;
		private SafeNumericUpDown nudCoinsPlatinum;
		private System.Windows.Forms.Label labelPlatinumCoins;
		private SafeNumericUpDown nudCoinsCopper;
		private SafeNumericUpDown nudCoinsSilver;
		private SafeNumericUpDown nudCoinsGold;
		private System.Windows.Forms.Label labelCoins;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TabControl tabControlEquipment;
		private System.Windows.Forms.Label labelItemRarity;
		private System.Windows.Forms.CheckBox checkBoxItemAdapted;
		private SafeNumericUpDown nudItemCount;
		private System.Windows.Forms.Label labelItemCount;
		private System.Windows.Forms.ComboBox comboBoxItemRarity;
		private System.Windows.Forms.TabPage tabPageAbout;
		private System.Windows.Forms.Label labelAboutEditorName;
		private System.Windows.Forms.LinkLabel linkLabelX2048;
		private System.Windows.Forms.PictureBox pictureBoxX2048;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label labelCopyright;
		private System.Windows.Forms.GroupBox groupBoxItemStats;
		private System.Windows.Forms.GroupBox groupBoxItemFlags;
		private System.Windows.Forms.Label labelItemModelId;
		private SafeNumericUpDown safeNumericUpDown2;
		private System.Windows.Forms.Label label5;
		private SafeNumericUpDown safeNumericUpDown1;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label1;
		private SafeNumericUpDown safeNumericUpDown9;
		private SafeNumericUpDown safeNumericUpDown8;
		private SafeNumericUpDown safeNumericUpDown7;
		private SafeNumericUpDown safeNumericUpDown6;
		private SafeNumericUpDown safeNumericUpDown5;
		private SafeNumericUpDown safeNumericUpDown4;
		private SafeNumericUpDown safeNumericUpDown3;
	}
}