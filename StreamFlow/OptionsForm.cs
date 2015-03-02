// Little Byte Games

using System;
using System.IO;
using System.Windows.Forms;

namespace StreamFlow
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();

            FileTextBox.Text = MainForm.DirectoryPath;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                MainForm.DirectoryPath = folderBrowserDialog1.SelectedPath;
                FileTextBox.Text = folderBrowserDialog1.SelectedPath;
                File.WriteAllText("Settings.txt", folderBrowserDialog1.SelectedPath);
            }
        }
    }
}