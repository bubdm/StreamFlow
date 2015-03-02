// Little Byte Games

using System;
using System.IO;
using System.Windows.Forms;

namespace StreamFlow
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            FileTextBox.Text = OBSSettings.DirectoryPath;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                OBSSettings.SetDirectoyPath(folderBrowserDialog1.SelectedPath);
                FileTextBox.Text = folderBrowserDialog1.SelectedPath;
                File.WriteAllText("Settings.txt", folderBrowserDialog1.SelectedPath);
            }
        }
    }
}