// Little Byte Games

using System;

namespace StreamFlow
{
    /// <summary>
    /// A competitor in this competition.
    /// </summary>
    public class Participant : IComparable<Participant>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ChallongeUsername { get; set; }

        public int Seed { get; set; }

        public string Misc { get; set; }

        public string NameOrUsername { get { return string.IsNullOrEmpty(Name) ? ChallongeUsername : Name; } }

        #region Readonly Fields

        public readonly string username;

        #endregion

        #region Constructor

        public Participant(string username)
        {
            this.username = username;
        }

        #endregion

        #region IComparable Overrides

        public int CompareTo(Participant other)
        {
            return username.CompareTo(other.username);
        }

        #endregion
    }
}