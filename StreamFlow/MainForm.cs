// Little Byte Games

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace StreamFlow
{
    /// <summary>
    /// Main form of the application.
    /// </summary>
    public partial class MainForm : Form
    {
        public static List<string> ParticipantList = new List<string>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs args)
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
        }

        private void Player1ComboBox_SelectedIndexChanged(object sender, EventArgs args)
        {
            OBSSettings.SetPlayer1Name(Player1ComboBox.SelectedItem.ToString());
        }

        private void Player2ComboBox_SelectedIndexChanged(object sender, EventArgs args)
        {
            OBSSettings.SetPlayer2Name(Player2ComboBox.SelectedItem.ToString());
        }

        private void Player1ScoreBox_ValueChanged(object sender, EventArgs args)
        {
            OBSSettings.SetPlayer1Score(Player1ScoreBox.Value);
        }

        private void Player2ScoreBox_ValueChanged(object sender, EventArgs args)
        {
            OBSSettings.SetPlayer2Score(Player2ScoreBox.Value);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs args)
        {
            SettingsForm optionsForm = new SettingsForm();
            optionsForm.ShowDialog(this);
        }

        private void ParticipantAddButton_Click(object sender, EventArgs args)
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
            if(filePrint.Length > 0)
            {
                filePrint = filePrint.Remove(filePrint.Length - 1);
            }
            File.WriteAllText("Participants.txt", filePrint);
        }

        private void ParticipantRemoveButton_Click(object sender, EventArgs args)
        {
            if(ParticipantListBox.SelectedIndex != -1)
            {
                ParticipantListBox.Items.Remove(ParticipantListBox.SelectedItem);
                Player1ComboBox.Items.Remove(ParticipantListBox.SelectedItem);
                Player2ComboBox.Items.Remove(ParticipantListBox.SelectedItem);
            }
            String filePrint = ParticipantListBox.Items.Cast<object>().Aggregate("", (current, item) => current + (item + ","));
            if(filePrint.Length > 0)
            {
                filePrint = filePrint.Remove(filePrint.Length - 1);
            }
            File.WriteAllText("Participants.txt", filePrint);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs args)
        {
            AboutDialog dialog = new AboutDialog();
            dialog.ShowDialog(this);
        }
    }
}