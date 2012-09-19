namespace Sdev.Shooting.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Klasse für ein Team. Ein Team besteht aus mehreren Playern.
    /// </summary>
    public class Team
    {
        #region ctors
        /// <summary>
        /// Erstellt eine neue Mannschaft.
        /// </summary>
        public Team()
        {
            this.Players = new List<Player>();
        }
        #endregion

        #region Name
        /// <summary>
        /// Liefert oder setzt den Namen.
        /// </summary>
        public string Name { get; set; }
        #endregion

        #region Teamnumber
        /// <summary>
        /// Liefert oder setzt die Teamnumber.
        /// </summary>
        public string Teamnumber { get; set; }
        #endregion

        #region Players
        /// <summary>
        /// Liefert die Schützen der Mannschaft.
        /// </summary>
        public IList<Player> Players { get; private set; }
        #endregion
    }
}
