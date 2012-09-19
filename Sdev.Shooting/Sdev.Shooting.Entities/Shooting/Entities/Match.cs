namespace Sdev.Shooting.Entities
{
    using System;

    /// <summary>
    /// Klasse steht für einen Wettkampf.
    /// In einem Wettkampf treten immer zwei Teams gegeneinander an.
    /// </summary>
    public class Match
    {
        #region ctors
        /// <summary>
        /// Erstellt eine neue Instanz der Klasse Match.
        /// </summary>
        public Match()
        {
            this.HomeTeam = new Team();
            this.GuestTeam = new Team();
        }
        #endregion

        #region Date
        /// <summary>
        /// Liefert oder setzt das Date.
        /// </summary>
        public DateTime Date { get; set; }
        #endregion

        #region Start
        /// <summary>
        /// Liefert oder setzt das Start.
        /// </summary>
        public DateTime Start { get; set; }
        #endregion

        #region End
        /// <summary>
        /// Liefert oder setzt das End.
        /// </summary>
        public DateTime End { get; set; }
        #endregion

        #region MatchType
        /// <summary>
        /// Liefert oder setzt den MatchType.
        /// </summary>
        public string MatchType { get; set; }
        #endregion

        #region MatchClass
        /// <summary>
        /// Liefert oder setzt die MatchClass.
        /// </summary>
        public string MatchClass { get; set; }
        #endregion

        #region City
        /// <summary>
        /// Liefert oder setzt die City.
        /// </summary>
        public string City { get; set; }
        #endregion

        #region Comment
        /// <summary>
        /// Liefert oder setzt das Comment.
        /// </summary>
        public string Comment { get; set; }
        #endregion

        #region HomeTeam
        /// <summary>
        /// Liefert oder setzt das HomeTeam.
        /// </summary>
        public Team HomeTeam { get; set; }
        #endregion

        #region GuestTeam
        /// <summary>
        /// Liefert oder setzt das GuestTeam.
        /// </summary>
        public Team GuestTeam { get; set; }
        #endregion
    }
}
