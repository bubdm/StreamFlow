using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamFlow
{
    internal static class ChallongeSettings
    {
        #region Static Fields

        private static string apiKey = "";
        private static string subdomain = "";

        #endregion

        #region Const Fields

        public const string SettingsFile = "Challonge Settings.txt";

        #endregion

        #region Properties

        public static string APIKey
        {
            get { return apiKey; }
            set 
            { 
                apiKey = value;
                File.WriteAllLines(SettingsFile, GetSettingsList());
            }
        }

        public static string Subdomain
        {
            get { return subdomain; }
            set 
            { 
                subdomain = value;
                File.WriteAllLines(SettingsFile, GetSettingsList());
            }
        }

        #endregion

        #region Constructors

        static ChallongeSettings()
        {
            // load settings
            if(File.Exists(SettingsFile))
            {
                List<String> fileLines = File.ReadLines(SettingsFile).ToList();
                if (fileLines.Count > 0)
                {
                    apiKey = fileLines[0];
                }
                if (fileLines.Count > 1)
                {
                    subdomain = fileLines[1];
                }
            }
            else
            {
                File.WriteAllLines(SettingsFile, GetSettingsList());
            }
        }

        #endregion

        #region Pubic Methods

        public static List<String> GetSettingsList()
        {
            List<String> settings = new List<string>();
            settings.Add(apiKey);
            settings.Add(subdomain);

            return settings;
        }

        #endregion
    }
}
