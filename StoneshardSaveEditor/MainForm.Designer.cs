namespace StoneshardSaveEditor
{
    partial class MainForm
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
            this.readAllSavesButton = new System.Windows.Forms.Button();
            this.saveFolderTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ChangeFolder = new System.Windows.Forms.Button();
            this.dataFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.charDataGroupBox = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.characterDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDown9 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown8 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.removeAbilityButton = new System.Windows.Forms.Button();
            this.abilityListBox = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.charDataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.characterDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // readAllSavesButton
            // 
            this.readAllSavesButton.Location = new System.Drawing.Point(527, 4);
            this.readAllSavesButton.Name = "readAllSavesButton";
            this.readAllSavesButton.Size = new System.Drawing.Size(98, 23);
            this.readAllSavesButton.TabIndex = 1;
            this.readAllSavesButton.Text = "Read All Saves";
            this.readAllSavesButton.UseVisualStyleBackColor = true;
            this.readAllSavesButton.Click += new System.EventHandler(this.readAllSavesButton_Click);
            // 
            // saveFolderTextBox
            // 
            this.saveFolderTextBox.Location = new System.Drawing.Point(92, 6);
            this.saveFolderTextBox.Name = "saveFolderTextBox";
            this.saveFolderTextBox.Size = new System.Drawing.Size(389, 20);
            this.saveFolderTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data Folder:";
            // 
            // ChangeFolder
            // 
            this.ChangeFolder.Location = new System.Drawing.Point(487, 3);
            this.ChangeFolder.Name = "ChangeFolder";
            this.ChangeFolder.Size = new System.Drawing.Size(34, 23);
            this.ChangeFolder.TabIndex = 5;
            this.ChangeFolder.Text = "...";
            this.ChangeFolder.UseVisualStyleBackColor = true;
            this.ChangeFolder.Click += new System.EventHandler(this.ChangeFolder_Click);
            // 
            // dataFolderBrowser
            // 
            this.dataFolderBrowser.Description = "Select folder with Stoneshard\'s saves";
            this.dataFolderBrowser.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.dataFolderBrowser.ShowNewFolderButton = false;
            // 
            // treeView1
            // 
            this.treeView1.HideSelection = false;
            this.treeView1.Location = new System.Drawing.Point(12, 34);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(223, 328);
            this.treeView1.TabIndex = 6;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // charDataGroupBox
            // 
            this.charDataGroupBox.Controls.Add(this.saveButton);
            this.charDataGroupBox.Controls.Add(this.textBox2);
            this.charDataGroupBox.Controls.Add(this.textBox1);
            this.charDataGroupBox.Controls.Add(this.label12);
            this.charDataGroupBox.Controls.Add(this.numericUpDown9);
            this.charDataGroupBox.Controls.Add(this.numericUpDown8);
            this.charDataGroupBox.Controls.Add(this.numericUpDown7);
            this.charDataGroupBox.Controls.Add(this.numericUpDown6);
            this.charDataGroupBox.Controls.Add(this.numericUpDown5);
            this.charDataGroupBox.Controls.Add(this.numericUpDown4);
            this.charDataGroupBox.Controls.Add(this.numericUpDown3);
            this.charDataGroupBox.Controls.Add(this.numericUpDown2);
            this.charDataGroupBox.Controls.Add(this.numericUpDown1);
            this.charDataGroupBox.Controls.Add(this.groupBox1);
            this.charDataGroupBox.Controls.Add(this.label11);
            this.charDataGroupBox.Controls.Add(this.label10);
            this.charDataGroupBox.Controls.Add(this.label9);
            this.charDataGroupBox.Controls.Add(this.label8);
            this.charDataGroupBox.Controls.Add(this.label7);
            this.charDataGroupBox.Controls.Add(this.label6);
            this.charDataGroupBox.Controls.Add(this.label5);
            this.charDataGroupBox.Controls.Add(this.label4);
            this.charDataGroupBox.Controls.Add(this.label3);
            this.charDataGroupBox.Controls.Add(this.label2);
            this.charDataGroupBox.Enabled = false;
            this.charDataGroupBox.Location = new System.Drawing.Point(241, 32);
            this.charDataGroupBox.Name = "charDataGroupBox";
            this.charDataGroupBox.Size = new System.Drawing.Size(384, 330);
            this.charDataGroupBox.TabIndex = 7;
            this.charDataGroupBox.TabStop = false;
            this.charDataGroupBox.Text = "Character Data";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(286, 298);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(92, 26);
            this.saveButton.TabIndex = 40;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.characterDataBindingSource, "GameTime", true));
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(69, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(111, 20);
            this.textBox2.TabIndex = 39;
            // 
            // characterDataBindingSource
            // 
            this.characterDataBindingSource.DataSource = typeof(StoneshardSaveEditor.CharacterData);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.characterDataBindingSource, "Name", true));
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(69, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(111, 20);
            this.textBox1.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(6, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 19);
            this.label12.TabIndex = 37;
            this.label12.Text = "Game Time";
            // 
            // numericUpDown9
            // 
            this.numericUpDown9.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.characterDataBindingSource, "XP", true));
            this.numericUpDown9.Location = new System.Drawing.Point(104, 279);
            this.numericUpDown9.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericUpDown9.Name = "numericUpDown9";
            this.numericUpDown9.Size = new System.Drawing.Size(76, 20);
            this.numericUpDown9.TabIndex = 36;
            this.numericUpDown9.ValueChanged += new System.EventHandler(this.EnableSaveButton);
            // 
            // numericUpDown8
            // 
            this.numericUpDown8.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.characterDataBindingSource, "Level", true));
            this.numericUpDown8.Location = new System.Drawing.Point(104, 253);
            this.numericUpDown8.Name = "numericUpDown8";
            this.numericUpDown8.Size = new System.Drawing.Size(76, 20);
            this.numericUpDown8.TabIndex = 35;
            this.numericUpDown8.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown8.ValueChanged += new System.EventHandler(this.EnableSaveButton);
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.characterDataBindingSource, "StatsPoints", true));
            this.numericUpDown7.Location = new System.Drawing.Point(104, 227);
            this.numericUpDown7.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(76, 20);
            this.numericUpDown7.TabIndex = 34;
            this.numericUpDown7.ValueChanged += new System.EventHandler(this.EnableSaveButton);
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.characterDataBindingSource, "AbilityPoints", true));
            this.numericUpDown6.Location = new System.Drawing.Point(104, 201);
            this.numericUpDown6.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(76, 20);
            this.numericUpDown6.TabIndex = 33;
            this.numericUpDown6.ValueChanged += new System.EventHandler(this.EnableSaveButton);
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.characterDataBindingSource, "Willpower", true));
            this.numericUpDown5.Location = new System.Drawing.Point(104, 175);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(76, 20);
            this.numericUpDown5.TabIndex = 32;
            this.numericUpDown5.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown5.ValueChanged += new System.EventHandler(this.EnableSaveButton);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.characterDataBindingSource, "Vitality", true));
            this.numericUpDown4.Location = new System.Drawing.Point(104, 149);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(76, 20);
            this.numericUpDown4.TabIndex = 31;
            this.numericUpDown4.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown4.ValueChanged += new System.EventHandler(this.EnableSaveButton);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.characterDataBindingSource, "Perception", true));
            this.numericUpDown3.Location = new System.Drawing.Point(104, 123);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(76, 20);
            this.numericUpDown3.TabIndex = 30;
            this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.EnableSaveButton);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.characterDataBindingSource, "Agility", true));
            this.numericUpDown2.Location = new System.Drawing.Point(104, 97);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(76, 20);
            this.numericUpDown2.TabIndex = 29;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.EnableSaveButton);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.characterDataBindingSource, "Strength", true));
            this.numericUpDown1.Location = new System.Drawing.Point(104, 71);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(76, 20);
            this.numericUpDown1.TabIndex = 28;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.EnableSaveButton);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.removeAbilityButton);
            this.groupBox1.Controls.Add(this.abilityListBox);
            this.groupBox1.Location = new System.Drawing.Point(186, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 279);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Abilities";
            // 
            // removeAbilityButton
            // 
            this.removeAbilityButton.Enabled = false;
            this.removeAbilityButton.Location = new System.Drawing.Point(100, 250);
            this.removeAbilityButton.Name = "removeAbilityButton";
            this.removeAbilityButton.Size = new System.Drawing.Size(86, 23);
            this.removeAbilityButton.TabIndex = 1;
            this.removeAbilityButton.Text = "Remove Ability";
            this.removeAbilityButton.UseVisualStyleBackColor = true;
            this.removeAbilityButton.Click += new System.EventHandler(this.removeAbilityButton_Click);
            // 
            // abilityListBox
            // 
            this.abilityListBox.FormattingEnabled = true;
            this.abilityListBox.Location = new System.Drawing.Point(6, 19);
            this.abilityListBox.Name = "abilityListBox";
            this.abilityListBox.Size = new System.Drawing.Size(180, 225);
            this.abilityListBox.TabIndex = 0;
            this.abilityListBox.SelectedValueChanged += new System.EventHandler(this.abilityListBox_SelectedValueChanged);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(6, 281);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 19);
            this.label11.TabIndex = 25;
            this.label11.Text = "XP";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(6, 255);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 19);
            this.label10.TabIndex = 23;
            this.label10.Text = "Level";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(6, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 19);
            this.label9.TabIndex = 21;
            this.label9.Text = "Stats Points";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(6, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "Ability Points";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Willpower";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Vitality";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Perception";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Agility";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Strength";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 373);
            this.Controls.Add(this.charDataGroupBox);
            this.Controls.Add(this.ChangeFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.saveFolderTextBox);
            this.Controls.Add(this.readAllSavesButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Stoneshard Save Editor v.1.1 (Tested with Stoneshard 0.8.0.12)";
            this.charDataGroupBox.ResumeLayout(false);
            this.charDataGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.characterDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button saveButton;

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;

        private System.Windows.Forms.Label label12;

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.NumericUpDown numericUpDown7;
        private System.Windows.Forms.NumericUpDown numericUpDown8;
        private System.Windows.Forms.NumericUpDown numericUpDown9;

        private System.Windows.Forms.Button removeAbilityButton;

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox abilityListBox;

        private System.Windows.Forms.Label label10;

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox charDataGroupBox;

        private System.Windows.Forms.FolderBrowserDialog dataFolderBrowser;

        private System.Windows.Forms.Button ChangeFolder;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox saveFolderTextBox;

        private System.Windows.Forms.Button readAllSavesButton;

		#endregion

		private System.Windows.Forms.BindingSource characterDataBindingSource;
    }
}