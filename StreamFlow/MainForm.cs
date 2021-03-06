// Little Byte Games

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace StreamFlow
{
    /// <summary>
    /// Main form of the application.
    /// </summary>
    public partial class MainForm : Form
    {
        public static List<Tournament> TournamentList = new List<Tournament>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs args)
        {
            StreamFlow.Participants.Initialize(ParticipantListBox, Player1ComboBox, Player2ComboBox);
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
                if(StreamFlow.Participants.Add(new Participant(ParticipantAddBox.Text)))
                {
                    ParticipantAddBox.Text = string.Empty;
                }
            }
        }

        private void ParticipantRemoveButton_Click(object sender, EventArgs args)
        {
            if(ParticipantListBox.SelectedIndex != -1)
            {
                StreamFlow.Participants.Remove(ParticipantListBox.SelectedItem.ToString());
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs args)
        {
            AboutDialog dialog = new AboutDialog();
            dialog.ShowDialog(this);
        }

        private void LoadParticipants_Click(object sender, EventArgs e)
        {
            ParticipantsFile.Filter = @"Text files (*.txt)|*.txt";
            ParticipantsFile.FileOk += OnParticipantsFileSelected;
            ParticipantsFile.ShowDialog(this);
        }

        private void OnParticipantsFileSelected(object sender, CancelEventArgs args)
        {
            ParticipantsFile.FileOk -= OnParticipantsFileSelected;
            StreamFlow.Participants.LoadFromFile(((OpenFileDialog)sender).FileName);
        }

        private void GetTournamentButton_Click(object sender, EventArgs e)
        {
            TournamentList = ChallongeSettings.ChallongeAPIObject.GetTournaments().ToList();

            foreach(Tournament tourny in TournamentList)
            {
                TournamentListBox.Items.Add(tourny.Name);
            }
        }

        private void GetParticpantsButton_Click(object sender, EventArgs e)
        {
            if(TournamentListBox.SelectedIndex != -1)
            {
                Tournament SelectedTourny = null;
                foreach(Tournament tourny in TournamentList)
                {
                    if(tourny.Name == TournamentListBox.SelectedItem)
                    {
                        SelectedTourny = tourny;
                        break;
                    }
                }
                if(SelectedTourny != null)
                {
                    List<Participant> participants = ChallongeSettings.ChallongeAPIObject.GetParticipants(SelectedTourny.Id).ToList();

                    ChallongeParticipantsListBox.Items.Clear();
                    foreach(Participant participant in participants)
                    {
                        ChallongeParticipantsListBox.Items.Add(participant.NameOrUsername);
                        if(participant.NameOrUsername == "")
                        {
                            int i = 0;
                        }
                    }
                }
            }
        }
    }
}