namespace Sdev.Shooting.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Klasse für einen Schützen.
    /// </summary>
    public class Player
    {
        #region ctors
        /// <summary>
        /// Erstellt eine neue Instanz der Klasse Player.
        /// </summary>
        public Player()
        {
            this.Shots = new List<Shot>();
        }
        #endregion

        #region Forename
        /// <summary>
        /// Liefert oder setzt den Forename.
        /// </summary>
        public string Forename { get; set; }
        #endregion

        #region Lastname
        /// <summary>
        /// Liefert oder setzt den Lastname.
        /// </summary>
        public string Lastname { get; set; }
        #endregion

        #region Passnumber
        /// <summary>
        /// Liefert oder setzt die Passnumber.
        /// </summary>
        public string Passnumber { get; set; }
        #endregion

        #region Position
        /// <summary>
        /// Liefert oder setzt die Position.
        /// </summary>
        public int Position { get; set; }
        #endregion

        #region Buttsnumber
        /// <summary>
        /// Liefert oder setzt die Buttsnumber (Standnummer).
        /// </summary>
        public int Buttsnumber { get; set; }
        #endregion

        #region Shots
        /// <summary>
        /// Liefert die Shots.
        /// </summary>
        public IList<Shot> Shots { get; private set; }
        #endregion
    }
}
