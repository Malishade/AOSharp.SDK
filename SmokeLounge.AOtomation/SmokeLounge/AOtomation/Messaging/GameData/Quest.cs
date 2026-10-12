// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Quest.cs" company="SmokeLounge">
//   Copyright © 2013 SmokeLounge.
//   This program is free software. It comes without any warranty, to
//   the extent permitted by applicable law. You can redistribute it
//   and/or modify it under the terms of the Do What The Fuck You Want
//   To Public License, Version 2, as published by Sam Hocevar. See
//   http://www.wtfpl.net/ for more details.
// </copyright>
// <summary>
//   Defines the Quest type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using AOSharp.Common.GameData;

namespace SmokeLounge.AOtomation.Messaging.GameData
{
    using System.Collections.Generic;

    /// <summary>
    /// The client's Quest_t (0xf8 bytes), versions 7 to 15: each later field is read only from the version that added
    /// it, taking the default otherwise. Unknowns are named by their offset in it; those the client reads and does
    /// not store, by their order.
    /// </summary>
    public class Quest
    {
        #region Constructors and Destructors

        public Quest()
        {
            this.Version = 15;
            this.Name = string.Empty;
            this.Description = string.Empty;
            this.Reward = new QuestReward();
            this.Actions = new List<QuestActionInfo>();
            this.Receivers = new List<Identity>();
            this.Receivers2 = new List<Identity>();
            this.Ints60 = new List<int>();
            this.Ints50 = new List<int>();
            this.PairsC8 = new List<KeyValuePair<Identity, int>>();
            this.Blocks = new List<QuestBlock>();
            this.UnknownA8 = 6;
        }

        #endregion

        #region Public Properties

        public Identity Identity { get; set; }

        public int Version { get; set; }

        /// <summary>After the version; not stored by the client.</summary>
        public int Unknown1 { get; set; }

        /// <summary>After <see cref="Unknown1"/>; not stored by the client.</summary>
        public int Unknown2 { get; set; }

        /// <summary>Bit 8: a team mission; bit 10: the client does not let it be deleted.</summary>
        public int Flags { get; set; }

        public bool IsTeamMission
        {
            get
            {
                return (this.Flags >> 8 & 1) != 0;
            }
        }

        public bool CanDelete
        {
            get
            {
                return (this.Flags >> 10 & 1) == 0;
            }
        }

        /// <summary>At most 31 characters (the client's field is 32 bytes).</summary>
        public string Name { get; set; }

        /// <summary>1 to 4096 characters.</summary>
        public string Description { get; set; }

        public Identity Identity38 { get; set; }

        public QuestReward Reward { get; set; }

        public Identity Identity40 { get; set; }

        public int Icon { get; set; }

        public int Unknown70 { get; set; }

        public int Unknown74 { get; set; }

        public List<QuestActionInfo> Actions { get; set; }

        /// <summary>The first identity list; the client merges it with <see cref="Receivers2"/>.</summary>
        public List<Identity> Receivers { get; set; }

        /// <summary>Masked to 0x7ffffff.</summary>
        public List<int> Ints60 { get; set; }

        /// <summary>Masked to 0x7ffffff.</summary>
        public List<int> Ints50 { get; set; }

        /// <summary>After <see cref="Ints50"/>; not stored by the client.</summary>
        public List<QuestBlock> Blocks { get; set; }

        /// <summary>From version 8 (6 before).</summary>
        public int UnknownA8 { get; set; }

        /// <summary>From version 9.</summary>
        public List<Identity> Receivers2 { get; set; }

        /// <summary>From version 10.</summary>
        public int Unknown4C { get; set; }

        /// <summary>From version 11.</summary>
        public int UnknownB0 { get; set; }

        /// <summary>From version 12.</summary>
        public Identity IdentityB4 { get; set; }

        /// <summary>From version 12.</summary>
        public int UnknownBC { get; set; }

        /// <summary>From version 12.</summary>
        public int UnknownC0 { get; set; }

        /// <summary>From version 13.</summary>
        public List<KeyValuePair<Identity, int>> PairsC8 { get; set; }

        /// <summary>From version 14.</summary>
        public int UnknownD4 { get; set; }

        /// <summary>From version 15; null before.</summary>
        public List<Identity> IdentitiesD8 { get; set; }

        #endregion
    }
}
