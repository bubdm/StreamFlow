namespace StreamFlow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Match = new System.Windows.Forms.TabPage();
            this.Player2ScoreBox = new System.Windows.Forms.NumericUpDown();
            this.Player2ScoreLabel = new System.Windows.Forms.Label();
            this.Player1ScoreBox = new System.Windows.Forms.NumericUpDown();
            this.Player1ScoreLabel = new System.Windows.Forms.Label();
            this.Player2ComboBox = new System.Windows.Forms.ComboBox();
            this.Player2Label = new System.Windows.Forms.Label();
            this.Player1ComboBox = new System.Windows.Forms.ComboBox();
            this.Player1Label = new System.Windows.Forms.Label();
            this.Participants = new System.Windows.Forms.TabPage();
            this.ParticipantAddBox = new System.Windows.Forms.TextBox();
            this.ParticipantRemoveButton = new System.Windows.Forms.Button();
            this.ParticipantAddButton = new System.Windows.Forms.Button();
            this.ParticipantListBox = new System.Windows.Forms.ListBox();
            this.ParticipantsFile = new System.Windows.Forms.OpenFileDialog();
            this.LoadParticipants = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Match.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player2ScoreBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1ScoreBox)).BeginInit();
            this.Participants.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            resources.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Match);
            this.tabControl1.Controls.Add(this.Participants);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // Match
            // 
            this.Match.Controls.Add(this.Player2ScoreBox);
            this.Match.Controls.Add(this.Player2ScoreLabel);
            this.Match.Controls.Add(this.Player1ScoreBox);
            this.Match.Controls.Add(this.Player1ScoreLabel);
            this.Match.Controls.Add(this.Player2ComboBox);
            this.Match.Controls.Add(this.Player2Label);
            this.Match.Controls.Add(this.Player1ComboBox);
            this.Match.Controls.Add(this.Player1Label);
            resources.ApplyResources(this.Match, "Match");
            this.Match.Name = "Match";
            this.Match.UseVisualStyleBackColor = true;
            // 
            // Player2ScoreBox
            // 
            resources.ApplyResources(this.Player2ScoreBox, "Player2ScoreBox");
            this.Player2ScoreBox.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.Player2ScoreBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.Player2ScoreBox.Name = "Player2ScoreBox";
            this.Player2ScoreBox.ValueChanged += new System.EventHandler(this.Player2ScoreBox_ValueChanged);
            // 
            // Player2ScoreLabel
            // 
            resources.ApplyResources(this.Player2ScoreLabel, "Player2ScoreLabel");
            this.Player2ScoreLabel.Name = "Player2ScoreLabel";
            // 
            // Player1ScoreBox
            // 
            resources.ApplyResources(this.Player1ScoreBox, "Player1ScoreBox");
            this.Player1ScoreBox.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.Player1ScoreBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.Player1ScoreBox.Name = "Player1ScoreBox";
            this.Player1ScoreBox.ValueChanged += new System.EventHandler(this.Player1ScoreBox_ValueChanged);
            // 
            // Player1ScoreLabel
            // 
            resources.ApplyResources(this.Player1ScoreLabel, "Player1ScoreLabel");
            this.Player1ScoreLabel.Name = "Player1ScoreLabel";
            // 
            // Player2ComboBox
            // 
            this.Player2ComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.Player2ComboBox, "Player2ComboBox");
            this.Player2ComboBox.Name = "Player2ComboBox";
            this.Player2ComboBox.SelectedIndexChanged += new System.EventHandler(this.Player2ComboBox_SelectedIndexChanged);
            // 
            // Player2Label
            // 
            resources.ApplyResources(this.Player2Label, "Player2Label");
            this.Player2Label.Name = "Player2Label";
            // 
            // Player1ComboBox
            // 
            this.Player1ComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.Player1ComboBox, "Player1ComboBox");
            this.Player1ComboBox.Name = "Player1ComboBox";
            this.Player1ComboBox.SelectedIndexChanged += new System.EventHandler(this.Player1ComboBox_SelectedIndexChanged);
            // 
            // Player1Label
            // 
            resources.ApplyResources(this.Player1Label, "Player1Label");
            this.Player1Label.Name = "Player1Label";
            // 
            // Participants
            // 
            this.Participants.Controls.Add(this.LoadParticipants);
            this.Participants.Controls.Add(this.ParticipantAddBox);
            this.Participants.Controls.Add(this.ParticipantRemoveButton);
            this.Participants.Controls.Add(this.ParticipantAddButton);
            this.Participants.Controls.Add(this.ParticipantListBox);
            resources.ApplyResources(this.Participants, "Participants");
            this.Participants.Name = "Participants";
            this.Participants.UseVisualStyleBackColor = true;
            // 
            // ParticipantAddBox
            // 
            resources.ApplyResources(this.ParticipantAddBox, "ParticipantAddBox");
            this.ParticipantAddBox.Name = "ParticipantAddBox";
            // 
            // ParticipantRemoveButton
            // 
            resources.ApplyResources(this.ParticipantRemoveButton, "ParticipantRemoveButton");
            this.ParticipantRemoveButton.Name = "ParticipantRemoveButton";
            this.ParticipantRemoveButton.UseVisualStyleBackColor = true;
            this.ParticipantRemoveButton.Click += new System.EventHandler(this.ParticipantRemoveButton_Click);
            // 
            // ParticipantAddButton
            // 
            resources.ApplyResources(this.ParticipantAddButton, "ParticipantAddButton");
            this.ParticipantAddButton.Name = "ParticipantAddButton";
            this.ParticipantAddButton.UseVisualStyleBackColor = true;
            this.ParticipantAddButton.Click += new System.EventHandler(this.ParticipantAddButton_Click);
            // 
            // ParticipantListBox
            // 
            this.ParticipantListBox.FormattingEnabled = true;
            resources.ApplyResources(this.ParticipantListBox, "ParticipantListBox");
            this.ParticipantListBox.Name = "ParticipantListBox";
            // 
            // ParticipantsFile
            // 
            this.ParticipantsFile.FileName = "ParticipantsFile";
            // 
            // LoadParticipants
            // 
            resources.ApplyResources(this.LoadParticipants, "LoadParticipants");
            this.LoadParticipants.Name = "LoadParticipants";
            this.LoadParticipants.UseVisualStyleBackColor = true;
            this.LoadParticipants.Click += new System.EventHandler(this.LoadParticipants_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.Match.ResumeLayout(false);
            this.Match.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player2ScoreBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1ScoreBox)).EndInit();
            this.Participants.ResumeLayout(false);
            this.Participants.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Match;
        private System.Windows.Forms.ComboBox Player1ComboBox;
        private System.Windows.Forms.Label Player1Label;
        private System.Windows.Forms.TabPage Participants;
        private System.Windows.Forms.ComboBox Player2ComboBox;
        private System.Windows.Forms.Label Player2Label;
        private System.Windows.Forms.Label Player1ScoreLabel;
        private System.Windows.Forms.NumericUpDown Player2ScoreBox;
        private System.Windows.Forms.Label Player2ScoreLabel;
        private System.Windows.Forms.NumericUpDown Player1ScoreBox;
        private System.Windows.Forms.TextBox ParticipantAddBox;
        private System.Windows.Forms.Button ParticipantRemoveButton;
        private System.Windows.Forms.Button ParticipantAddButton;
        private System.Windows.Forms.ListBox ParticipantListBox;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button LoadParticipants;
        private System.Windows.Forms.OpenFileDialog ParticipantsFile;
    }
}

