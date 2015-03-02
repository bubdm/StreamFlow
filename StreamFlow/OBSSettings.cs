// Little Byte Games

using System.IO;

namespace StreamFlow
{
    /// <summary>
    /// All settings corresponding to the OBS software.
    /// </summary>
    internal static class OBSSettings
    {
        #region Static Fields

        /// <summary>Path to the directory containing all of the OBS files and assets.</summary>
        private static string directoryPath = "C:\\";

        #endregion

        #region Const Fields

        /// <summary>Name of the file for all OBS settings.</summary>
        public const string SettingsFile = "OBS Settings.txt";

        /// <summary>Folder containing all of the files used to update text fields in OBS.</summary>
        private const string FilesFolder = "\\Files";

        /// <summary>Text file for the first player's username.</summary>
        private const string Player1NameFile = FilesFolder + "\\Player 1.txt";

        /// <summary>Text file for the second player's username.</summary>
        private const string Player2NameFile = FilesFolder + "\\Player 2.txt";

        /// <summary>Text file for the first player's score.</summary>
        private const string Player1ScoreFile = FilesFolder + "\\Player 1 Score.txt";

        /// <summary>Text file for the second player's score.</summary>
        private const string Player2ScoreFile = FilesFolder + "\\Player 2 Score.txt";

        #endregion

        #region Properties

        /// <summary>Path to the directory containing all of the OBS files and assets.</summary>
        public static string DirectoryPath
        {
            get { return directoryPath; }
        }

        #endregion

        #region Constructors

        static OBSSettings()
        {
            // load settings
            if(File.Exists(SettingsFile))
            {
                directoryPath = File.ReadAllText(SettingsFile);
            }
            else
            {
                File.WriteAllText(SettingsFile, directoryPath);
            }
        }

        #endregion

        #region Pubic Methods

        /// <summary>
        /// Update the path to the OBS assets folder.
        /// </summary>
        /// <param name="path">Path to the folder being used for OBS's assets.</param>
        public static void SetDirectoyPath(string path)
        {
            directoryPath = path;
            File.WriteAllText(SettingsFile, directoryPath);
        }

        /// <summary>
        /// Get Player 1's username.
        /// </summary>
        /// <returns>The current username for the first player.</returns>
        public static string GetPlayer1Name()
        {
            return File.ReadAllText(directoryPath + Player1NameFile);
        }

        /// <summary>
        /// Get Player 2's username.
        /// </summary>
        /// <returns>The current username for the second player.</returns>
        public static string GetPlayer2Name()
        {
            return File.ReadAllText(directoryPath + Player2NameFile);
        }

        /// <summary>
        /// Get Player 1's score.
        /// </summary>
        /// <returns>Player 1's current score.</returns>
        public static int GetPlayer1Score()
        {
            return int.Parse(File.ReadAllText(directoryPath + Player1ScoreFile));
        }

        /// <summary>
        /// Get Player 2's score.
        /// </summary>
        /// <returns>Player 2's current score.</returns>
        public static int GetPlayer2Score()
        {
            return int.Parse(File.ReadAllText(directoryPath + Player2ScoreFile));
        }

        /// <summary>
        /// Update Player 1's username.
        /// </summary>
        /// <param name="name">The new name to assign.</param>
        public static void SetPlayer1Name(string name)
        {
            File.WriteAllText(directoryPath + Player1NameFile, name);
        }

        /// <summary>
        /// Update Player 2's username.
        /// </summary>
        /// <param name="name">The new name assign.</param>
        public static void SetPlayer2Name(string name)
        {
            File.WriteAllText(directoryPath + Player2NameFile, name);
        }

        /// <summary>
        /// Update the Player 1's score.
        /// </summary>
        /// <param name="score">New score to assign.</param>
        public static void SetPlayer1Score(decimal score)
        {
            File.WriteAllText(directoryPath + Player1ScoreFile, score.ToString());
        }

        /// <summary>
        /// Update the Player 2's score.
        /// </summary>
        /// <param name="score">New score to assign.</param>
        public static void SetPlayer2Score(decimal score)
        {
            File.WriteAllText(directoryPath + Player2ScoreFile, score.ToString());
        }

        #endregion
    }
}