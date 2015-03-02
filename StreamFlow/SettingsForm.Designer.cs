namespace StreamFlow
{
    partial class SettingsForm
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
            this.FolderDirectoryLabel = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.FileTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.APIBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SubdomainBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FolderDirectoryLabel
            // 
            this.FolderDirectoryLabel.AutoSize = true;
            this.FolderDirectoryLabel.Location = new System.Drawing.Point(20, 38);
            this.FolderDirectoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FolderDirectoryLabel.Name = "FolderDirectoryLabel";
            this.FolderDirectoryLabel.Size = new System.Drawing.Size(102, 17);
            this.FolderDirectoryLabel.TabIndex = 0;
            this.FolderDirectoryLabel.Text = "Directory Path:";
            // 
            // FileTextBox
            // 
            this.FileTextBox.Location = new System.Drawing.Point(131, 34);
            this.FileTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FileTextBox.Name = "FileTextBox";
            this.FileTextBox.Size = new System.Drawing.Size(439, 22);
            this.FileTextBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(579, 32);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "OBS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Challonge";
            // 
            // APIBox
            // 
            this.APIBox.Location = new System.Drawing.Point(131, 89);
            this.APIBox.Margin = new System.Windows.Forms.Padding(4);
            this.APIBox.Name = "APIBox";
            this.APIBox.Size = new System.Drawing.Size(439, 22);
            this.APIBox.TabIndex = 5;
            this.APIBox.TextChanged += new System.EventHandler(this.APIBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "API Key:";
            // 
            // SubdomainBox
            // 
            this.SubdomainBox.Location = new System.Drawing.Point(131, 115);
            this.SubdomainBox.Margin = new System.Windows.Forms.Padding(4);
            this.SubdomainBox.Name = "SubdomainBox";
            this.SubdomainBox.Size = new System.Drawing.Size(439, 22);
            this.SubdomainBox.TabIndex = 8;
            this.SubdomainBox.TextChanged += new System.EventHandler(this.SubdomainBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Subdomain:";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 322);
            this.Controls.Add(this.SubdomainBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.APIBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FileTextBox);
            this.Controls.Add(this.FolderDirectoryLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.Text = "Options";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FolderDirectoryLabel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox FileTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox APIBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SubdomainBox;
        private System.Windows.Forms.Label label4;
    }
}