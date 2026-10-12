// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QuestActionInfo.cs" company="SmokeLounge">
//   Copyright © 2013 SmokeLounge.
//   This program is free software. It comes without any warranty, to
//   the extent permitted by applicable law. You can redistribute it
//   and/or modify it under the terms of the Do What The Fuck You Want
//   To Public License, Version 2, as published by Sam Hocevar. See
//   http://www.wtfpl.net/ for more details.
// </copyright>
// <summary>
//   Defines the QuestActionInfo type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using AOSharp.Common.GameData;

namespace SmokeLounge.AOtomation.Messaging.GameData
{
    /// <summary>The client's QuestAction_t (0x8c bytes). Unknowns are named by their offset in it.</summary>
    public class QuestActionInfo
    {
        #region Constructors and Destructors

        public QuestActionInfo()
        {
            this.Floats2C = new float[4];
            this.Floats44 = new float[4];
            this.WorldPos = new QuestWorldPos();
        }

        #endregion

        #region Public Properties

        /// <summary>The action's type (MissionActionType).</summary>
        public int Type { get; set; }

        public Identity Identity04 { get; set; }

        public Identity Identity0C { get; set; }

        public Identity Identity14 { get; set; }

        public Identity Identity1C { get; set; }

        public Identity Identity24 { get; set; }

        public float[] Floats2C { get; set; }

        public Identity Identity3C { get; set; }

        public float[] Floats44 { get; set; }

        public Identity Identity54 { get; set; }

        /// <summary>When it expires (the client's remaining time counts to it).</summary>
        public uint ExpiryTime { get; set; }

        public int Unknown60 { get; set; }

        public Identity Identity64 { get; set; }

        public QuestWorldPos WorldPos { get; set; }

        #endregion
    }
}
