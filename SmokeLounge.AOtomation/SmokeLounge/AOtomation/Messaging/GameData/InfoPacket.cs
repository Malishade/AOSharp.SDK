// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InfoPacket.cs" company="SmokeLounge">
//   Copyright © 2013 SmokeLounge.
//   This program is free software. It comes without any warranty, to
//   the extent permitted by applicable law. You can redistribute it
//   and/or modify it under the terms of the Do What The Fuck You Want
//   To Public License, Version 2, as published by Sam Hocevar. See
//   http://www.wtfpl.net/ for more details.
// </copyright>
// <summary>
//   Defines the InfoPacket type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SmokeLounge.AOtomation.Messaging.GameData
{
    using System.Collections.Generic;

    /// <summary>
    /// The client's InfoPacket_t as InfoPacketIIR_t's reader fills it: a byte of flags saying which blocks follow,
    /// then a character's info. Where a field sets a stat the client's handler names it after the stat.
    /// </summary>
    public class InfoPacket
    {
        #region Constants

        /// <summary>The value a stat field holds when the packet does not say.</summary>
        public const int NoValue = 1234567890;

        /// <summary>Flag: the clan level, then (with <see cref="DestinationsFlag"/>) the destinations, then the clan's city.</summary>
        public const byte ClanFlag = 0x01;

        public const byte DestinationsFlag = 0x02;

        public const byte ItemsFlag = 0x04;

        public const byte GasFlag = 0x08;

        /// <summary>Flag: the PvP stats are left out.</summary>
        public const byte NoPvpFlag = 0x10;

        public const byte FactionsFlag = 0x20;

        public const byte Unknown1Flag = 0x40;

        #endregion

        #region Constructors and Destructors

        public InfoPacket()
        {
            this.FirstName = string.Empty;
            this.LastName = string.Empty;
            this.TitleName = string.Empty;
            this.Info = string.Empty;
            this.ClanLevel = string.Empty;
            this.Destinations = new List<GridDestination>();
            this.Items = new List<AcgItem>();
            this.Factions = new int[12];
            this.PvpStats = new int[8];
            this.InvadersKilled = NoValue;
            this.KilledByInvaders = NoValue;
            this.AlienLevel = NoValue;
        }

        #endregion

        #region Public Properties

        /// <summary>Which blocks follow (the *Flag constants).</summary>
        public byte Flags { get; set; }

        /// <summary>Read only with <see cref="Unknown1Flag"/>, else 0; when 0, <see cref="Unknown2"/> follows TitleLevel.</summary>
        public byte Unknown1 { get; set; }

        public byte Profession { get; set; }

        public byte ProfessionLevel { get; set; }

        public byte TitleLevel { get; set; }

        /// <summary>Sent after TitleLevel only when <see cref="Unknown1"/> is 0; not stored by the client.</summary>
        public byte Unknown2 { get; set; }

        public byte VisualProfession { get; set; }

        /// <summary>Read by the client as an unsigned short (its side XP bonus).</summary>
        public ushort SideXpBonus { get; set; }

        public int Health { get; set; }

        public int MaxHealth { get; set; }

        /// <summary>An NPC's Taunt.</summary>
        public int Taunt { get; set; }

        /// <summary>An NPC's Clan.</summary>
        public int Clan { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string TitleName { get; set; }

        /// <summary>The info text.</summary>
        public string Info { get; set; }

        /// <summary>With <see cref="ClanFlag"/>.</summary>
        public string ClanLevel { get; set; }

        /// <summary>With <see cref="ClanFlag"/> and <see cref="DestinationsFlag"/>: a GridDestinationList_t.</summary>
        public List<GridDestination> Destinations { get; set; }

        /// <summary>With <see cref="ClanFlag"/>: the clan member's city.</summary>
        public int ClanCity { get; set; }

        /// <summary>With <see cref="ItemsFlag"/>: the ACG items.</summary>
        public List<AcgItem> Items { get; set; }

        /// <summary>With <see cref="GasFlag"/>.</summary>
        public int GasSeconds { get; set; }

        /// <summary>With <see cref="GasFlag"/>.</summary>
        public byte Gas { get; set; }

        /// <summary>
        /// With <see cref="FactionsFlag"/>: ClanSentinels, OTMed, ClanGaia, OTTrans, ClanVanguards, GOS, OTFollowers,
        /// OTOperator, OTUnredeemed, ClanDevoted, ClanConserver, ClanRedeemed.
        /// </summary>
        public int[] Factions { get; set; }

        public int InvadersKilled { get; set; }

        public int KilledByInvaders { get; set; }

        public int AlienLevel { get; set; }

        /// <summary>
        /// Without <see cref="NoPvpFlag"/>: PVPDuelKills, PVPDuelDeaths, PVPProfessionDuelKills, PVPRankedSoloKills,
        /// PVPRankedTeamKills, PVPSoloScore, PVPTeamScore, PVPDuelScore.
        /// </summary>
        public int[] PvpStats { get; set; }

        #endregion
    }
}
