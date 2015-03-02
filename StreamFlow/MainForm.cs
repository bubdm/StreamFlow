// Little Byte Games

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace StreamFlow
{
    public partial class MainForm : Form
    {
        public static string DirectoryPath = "C:\\";

        private const string Player1NameFile = "\\Player 1.txt";
        private const string Player2NameFile = "\\Player 2.txt";
        private const string Player1ScoreFile = "\\Player 1 Score.txt";
        private const string Player2ScoreFile = "\\Player 2 Score.txt";

        public static List<string> ParticipantList = new List<string>();

        public MainForm()
        {
            InitializeComponent();

            if(File.Exists("Settings.txt"))
            {
                DirectoryPath = File.ReadAllText("Settings.txt");
            }
            else
            {
                File.WriteAllText("Settings.txt", DirectoryPath);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(File.Exists("Participants.txt"))
            {
                ParticipantListBox.Items.AddRange(File.ReadAllText("Participants.txt").Split(','));

                foreach(object item in ParticipantListBox.Items)
                {
                    Player1ComboBox.Items.Add(item);
                    Player2ComboBox.Items.Add(item);
                }
            }

            if (File.Exists(DirectoryPath + Player1NameFile))
            {
                Player1ComboBox.SelectedItem = File.ReadAllText(DirectoryPath + Player1NameFile);
            }
            if (File.Exists(DirectoryPath + Player2NameFile))
            {
                Player2ComboBox.SelectedItem = File.ReadAllText(DirectoryPath + Player2NameFile);
            }
            if (File.Exists(DirectoryPath + Player1ScoreFile))
            {
                Player1ScoreBox.Value = Int32.Parse(File.ReadAllText(DirectoryPath + Player1ScoreFile));
            }
            if (File.Exists(DirectoryPath + Player2ScoreFile))
            {
                Player2ScoreBox.Value = Int32.Parse(File.ReadAllText(DirectoryPath + Player2ScoreFile));
            }
        }

        private void Player1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            File.WriteAllText(DirectoryPath + Player1NameFile, Player1ComboBox.SelectedItem.ToString());
        }

        private void Player2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            File.WriteAllText(DirectoryPath + Player2NameFile, Player2ComboBox.SelectedItem.ToString());
        }

        private void Player1ScoreBox_ValueChanged(object sender, EventArgs e)
        {
            File.WriteAllText(DirectoryPath + Player1ScoreFile, Player1ScoreBox.Value.ToString());
        }

        private void Player2ScoreBox_ValueChanged(object sender, EventArgs e)
        {
            File.WriteAllText(DirectoryPath + Player2ScoreFile, Player2ScoreBox.Value.ToString());
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OptionsForm optionsForm = new OptionsForm();
            optionsForm.ShowDialog(this);
        }

        private void ParticipantAddButton_Click(object sender, EventArgs e)
        {
            if(ParticipantAddBox.Text.Length > 0)
            {
                if(!ParticipantListBox.Items.Contains(ParticipantAddBox.Text))
                {
                    ParticipantListBox.Items.Add(ParticipantAddBox.Text);
                    Player1ComboBox.Items.Add(ParticipantAddBox.Text);
                    Player2ComboBox.Items.Add(ParticipantAddBox.Text);
                    ParticipantAddBox.Text = "";
                }
            }
            String filePrint = ParticipantListBox.Items.Cast<object>().Aggregate("", (current, item) => current + (item + ","));
            filePrint = filePrint.Remove(filePrint.Length - 1);
            File.WriteAllText("Participants.txt", filePrint);
        }

        private void ParticipantRemoveButton_Click(object sender, EventArgs e)
        {
            if(ParticipantListBox.SelectedIndex != -1)
            {
                ParticipantListBox.Items.Remove(ParticipantListBox.SelectedItem);
                Player1ComboBox.Items.Remove(ParticipantListBox.SelectedItem);
                Player2ComboBox.Items.Remove(ParticipantListBox.SelectedItem);
            }
            String filePrint = ParticipantListBox.Items.Cast<object>().Aggregate("", (current, item) => current + (item + ","));
            filePrint = filePrint.Remove(filePrint.Length - 1);
            File.WriteAllText("Participants.txt", filePrint);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutDialog dialog = new AboutDialog();
            dialog.ShowDialog(this);
        }
    }
}