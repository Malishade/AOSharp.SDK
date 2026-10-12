// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PlayfieldRecord.cs" company="SmokeLounge">
//   Copyright © 2013 SmokeLounge.
//   This program is free software. It comes without any warranty, to
//   the extent permitted by applicable law. You can redistribute it
//   and/or modify it under the terms of the Do What The Fuck You Want
//   To Public License, Version 2, as published by Sam Hocevar. See
//   http://www.wtfpl.net/ for more details.
// </copyright>
// <summary>
//   Defines the PlayfieldRecord type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SmokeLounge.AOtomation.Messaging.GameData
{
    using System.Collections.Generic;

    using AOSharp.Common.GameData;

    /// <summary>
    /// The client's RDBPlayfield_t as a PlayfieldAnarchyF carries it inline (record type 1000001): the playfield's
    /// header, then its rooms (indoors: a tilemap other than itself) or its zones' camera attractors (outdoors), its
    /// water, its environment and its destinations. Format versions below 7, and an id other than the inline
    /// identity's, fail the read.
    /// </summary>
    public class PlayfieldRecord
    {
        #region Constants

        public const int RecordType = 1000001;

        public const int MinFormatVersion = 7;

        #endregion

        #region Constructors and Destructors

        public PlayfieldRecord()
        {
            this.Name = string.Empty;
            this.Reserved = new byte[24];
            this.Rooms = new List<PlayfieldRoom>();
            this.Zones = new List<List<CameraAttractor>>();
            this.Water = new List<WaterMesh>();
            this.Environment = new byte[0];
            this.Destinations = new List<PlayfieldDestination>();
        }

        #endregion

        #region Public Properties

        public int Version { get; set; }

        public int Id { get; set; }

        /// <summary>At most 32 bytes.</summary>
        public string Name { get; set; }

        /// <summary>The playfield whose tiles it uses; another playfield's makes it indoors.</summary>
        public int TilemapId { get; set; }

        public int ZoneSize { get; set; }

        public bool IsIndoor
        {
            get
            {
                return this.TilemapId != this.Id;
            }
        }

        /// <summary>From format version 9.</summary>
        public int Flags { get; set; }

        public int UnknownV9B { get; set; }

        public int PlayfieldTypeBits { get; set; }

        public int UnknownV9C { get; set; }

        public int UnknownV9D { get; set; }

        /// <summary>24 bytes the client reserves (from format version 9).</summary>
        public byte[] Reserved { get; set; }

        /// <summary>Indoors: a room per zone.</summary>
        public List<PlayfieldRoom> Rooms { get; set; }

        /// <summary>Outdoors: each zone's camera attractors (from format version 5; none before).</summary>
        public List<List<CameraAttractor>> Zones { get; set; }

        public List<WaterMesh> Water { get; set; }

        public int Unknown3 { get; set; }

        public int Unknown4 { get; set; }

        /// <summary>
        /// The environment's format (0 or less: no environment). 26 sends 22 bytes, 29 sends 25, any other 26.
        /// </summary>
        public int EnvironmentVersion { get; set; }

        /// <summary>
        /// EnvironmentData_t's bytes as sent: 0..7 the weights of the eight weather kinds, 8..18 the parameters (10 and
        /// 11 swapped), 19..25 values passed through.
        /// </summary>
        public byte[] Environment { get; set; }

        public List<PlayfieldDestination> Destinations { get; set; }

        #endregion
    }
}
