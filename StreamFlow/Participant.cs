// Little Byte Games

using System;

namespace StreamFlow
{
    /// <summary>
    /// A competitor in this competition.
    /// </summary>
    internal class Participant : IComparable<Participant>
    {
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