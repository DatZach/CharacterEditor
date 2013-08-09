namespace CharacterEditor.Forms
{
	partial class FormItemStats
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormItemStats));
			this.labelDamage = new System.Windows.Forms.Label();
			this.labelAmor = new System.Windows.Forms.Label();
			this.labelResistance = new System.Windows.Forms.Label();
			this.labelTempo = new System.Windows.Forms.Label();
			this.labelCritical = new System.Windows.Forms.Label();
			this.labelRegeneration = new System.Windows.Forms.Label();
			this.labelHP = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelDamage
			// 
			this.labelDamage.AutoSize = true;
			this.labelDamage.Location = new System.Drawing.Point(12, 22);
			this.labelDamage.Name = "labelDamage";
			this.labelDamage.Size = new System.Drawing.Size(47, 13);
			this.labelDamage.TabIndex = 0;
			this.labelDamage.Text = "Damage";
			// 
			// labelAmor
			// 
			this.labelAmor.AutoSize = true;
			this.labelAmor.Location = new System.Drawing.Point(12, 37);
			this.labelAmor.Name = "labelAmor";
			this.labelAmor.Size = new System.Drawing.Size(34, 13);
			this.labelAmor.TabIndex = 1;
			this.labelAmor.Text = "Armor";
			// 
			// labelResistance
			// 
			this.labelResistance.AutoSize = true;
			this.labelResistance.Location = new System.Drawing.Point(12, 50);
			this.labelResistance.Name = "labelResistance";
			this.labelResistance.Size = new System.Drawing.Size(60, 13);
			this.labelResistance.TabIndex = 2;
			this.labelResistance.Text = "Resistance";
			// 
			// labelTempo
			// 
			this.labelTempo.AutoSize = true;
			this.labelTempo.Location = new System.Drawing.Point(12, 63);
			this.labelTempo.Name = "labelTempo";
			this.labelTempo.Size = new System.Drawing.Size(40, 13);
			this.labelTempo.TabIndex = 3;
			this.labelTempo.Text = "Tempo";
			// 
			// labelCritical
			// 
			this.labelCritical.AutoSize = true;
			this.labelCritical.Location = new System.Drawing.Point(12, 76);
			this.labelCritical.Name = "labelCritical";
			this.labelCritical.Size = new System.Drawing.Size(38, 13);
			this.labelCritical.TabIndex = 4;
			this.labelCritical.Text = "Critical";
			// 
			// labelRegeneration
			// 
			this.labelRegeneration.AutoSize = true;
			this.labelRegeneration.Location = new System.Drawing.Point(12, 89);
			this.labelRegeneration.Name = "labelRegeneration";
			this.labelRegeneration.Size = new System.Drawing.Size(71, 13);
			this.labelRegeneration.TabIndex = 5;
			this.labelRegeneration.Text = "Regeneration";
			// 
			// labelHP
			// 
			this.labelHP.AutoSize = true;
			this.labelHP.Location = new System.Drawing.Point(15, 6);
			this.labelHP.Name = "labelHP";
			this.labelHP.Size = new System.Drawing.Size(22, 13);
			this.labelHP.TabIndex = 6;
			this.labelHP.Text = "HP";
			// 
			// FormItemStats
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(356, 215);
			this.Controls.Add(this.labelHP);
			this.Controls.Add(this.labelRegeneration);
			this.Controls.Add(this.labelCritical);
			this.Controls.Add(this.labelTempo);
			this.Controls.Add(this.labelResistance);
			this.Controls.Add(this.labelAmor);
			this.Controls.Add(this.labelDamage);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormItemStats";
			this.ShowInTaskbar = false;
			this.Text = "Item Stats";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelDamage;
		private System.Windows.Forms.Label labelAmor;
		private System.Windows.Forms.Label labelResistance;
		private System.Windows.Forms.Label labelTempo;
		private System.Windows.Forms.Label labelCritical;
		private System.Windows.Forms.Label labelRegeneration;
		private System.Windows.Forms.Label labelHP;
	}
}