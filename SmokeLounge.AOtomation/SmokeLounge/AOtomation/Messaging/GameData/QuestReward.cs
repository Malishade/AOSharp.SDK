// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QuestReward.cs" company="SmokeLounge">
//   Copyright © 2013 SmokeLounge.
//   This program is free software. It comes without any warranty, to
//   the extent permitted by applicable law. You can redistribute it
//   and/or modify it under the terms of the Do What The Fuck You Want
//   To Public License, Version 2, as published by Sam Hocevar. See
//   http://www.wtfpl.net/ for more details.
// </copyright>
// <summary>
//   Defines the QuestReward type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using AOSharp.Common.GameData;

namespace SmokeLounge.AOtomation.Messaging.GameData
{
    using System.Collections.Generic;

    /// <summary>
    /// The reward a quest carries (versions 3 to 6), as the client reads it. Unknowns are named by their offset in
    /// the client's object. Two identity lists and an int are read and not kept.
    /// </summary>
    public class QuestReward
    {
        #region Constructors and Destructors

        public QuestReward()
        {
            this.Version = 6;
            this.Items = new List<AcgItem>();
            this.Identities1 = new List<Identity>();
            this.Identities2 = new List<Identity>();
            this.Item28 = new AcgItem();
        }

        #endregion

        #region Public Properties

        public int Version { get; set; }

        public int Cash { get; set; }

        /// <summary>After the cash; not stored by the client.</summary>
        public int Unknown1 { get; set; }

        public int Experience { get; set; }

        /// <summary>After the experience (at most 30000 each); not stored by the client.</summary>
        public List<Identity> Identities1 { get; set; }

        public List<Identity> Identities2 { get; set; }

        public List<AcgItem> Items { get; set; }

        /// <summary>From version 4.</summary>
        public int Unknown08 { get; set; }

        /// <summary>From version 4.</summary>
        public int Unknown14 { get; set; }

        /// <summary>From version 4.</summary>
        public int Unknown18 { get; set; }

        /// <summary>From version 5.</summary>
        public int Unknown0C { get; set; }

        /// <summary>From version 5.</summary>
        public int Unknown10 { get; set; }

        /// <summary>From version 6.</summary>
        public AcgItem Item28 { get; set; }

        #endregion
    }
}
