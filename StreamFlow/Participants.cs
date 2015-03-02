// Little Byte Games

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace StreamFlow
{
    /// <summary>
    /// Mantain a list of unique participants.
    /// </summary>
    internal static class Participants
    {
        #region Private Fields

        /// <summary>List of all participating competitors.</summary>
        private static List<Participant> participants = new List<Participant>();

        private static ListBox participantList;
        private static ComboBox player1DropDown;
        private static ComboBox player2DropDown;

        #endregion

        #region Public Methods

        public static void Initialize(ListBox participantList, ComboBox player1DropDown, ComboBox player2DropDown)
        {
            Participants.participantList = participantList;
            Participants.player1DropDown = player1DropDown;
            Participants.player2DropDown = player2DropDown;
        }

        /// <summary>
        /// Add a new participant.
        /// </summary>
        /// <param name="participant">New participant to save.</param>
        /// <returns>True if this participant has a unique username and was successfully added.</returns>
        public static bool Add(Participant participant)
        {
            if(participants.Any(p => p.username == participant.username))
            {
                return false;
            }

            participants.Add(participant);
            participants.Sort();

            participantList.Items.Clear();
            player1DropDown.Items.Clear();
            player2DropDown.Items.Clear();

            foreach(Participant part in participants)
            {
                participantList.Items.Add(part.username);
                player1DropDown.Items.Add(part.username);
                player2DropDown.Items.Add(part.username);
            }

            return true;
        }

        /// <summary>
        /// Remove a participant with the corresponding username.
        /// </summary>
        /// <param name="username">Username to search for.</param>
        public static void Remove(string username)
        {
            participants.Remove(participants.First(p => p.username == username));

            participantList.Items.Remove(username);
            player1DropDown.Items.Remove(username);
            player2DropDown.Items.Remove(username);
        }

        /// <summary>
        /// Create a new participant list from a file.
        /// </summary>
        /// <param name="filePath">Path to file containing newline separated usernames.</param>
        public static void LoadFromFile(string filePath)
        {
            participants = new List<Participant>();
            IEnumerable<string> usernames = File.ReadAllText(filePath).Split('\n').Where(username => !string.IsNullOrEmpty(username));
            foreach(string username in usernames)
            {
                Add(new Participant(username));
            }
        }

        #endregion
    }
}