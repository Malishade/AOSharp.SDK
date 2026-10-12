// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PlayfieldRoom.cs" company="SmokeLounge">
//   Copyright © 2013 SmokeLounge.
//   This program is free software. It comes without any warranty, to
//   the extent permitted by applicable law. You can redistribute it
//   and/or modify it under the terms of the Do What The Fuck You Want
//   To Public License, Version 2, as published by Sam Hocevar. See
//   http://www.wtfpl.net/ for more details.
// </copyright>
// <summary>
//   Defines the PlayfieldRoom type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SmokeLounge.AOtomation.Messaging.GameData
{
    using System.Collections.Generic;

    using AOSharp.Common.GameData;

    /// <summary>
    /// An indoor playfield's room (one per zone): its flags (the rotation in the low two bits; 0x80, a name follows),
    /// its tile rectangle, its place in the template, its door connections, a packed lightmap, its water and its
    /// camera attractors.
    /// </summary>
    public class PlayfieldRoom
    {
        #region Constructors and Destructors

        public PlayfieldRoom()
        {
            this.DoorConnections = new List<DoorConnection>();
            this.Name = string.Empty;
            this.Lightmap = new byte[0];
            this.Water = new List<WaterMesh>();
            this.CameraAttractors = new List<CameraAttractor>();
        }

        #endregion

        #region Public Properties

        public byte Flags { get; set; }

        public int Rotation
        {
            get
            {
                return this.Flags & 3;
            }
        }

        public byte Unused { get; set; }

        public short TileX1 { get; set; }

        public short TileY1 { get; set; }

        public short TileX2 { get; set; }

        public short TileY2 { get; set; }

        public Vector3 TemplatePosition { get; set; }

        public List<DoorConnection> DoorConnections { get; set; }

        /// <summary>With flag 0x80: at most 32 bytes.</summary>
        public string Name { get; set; }

        /// <summary>Whether <see cref="Lightmap"/> is packed (zlib); 0, the client takes no lightmap.</summary>
        public int LightmapPacked { get; set; }

        /// <summary>The lightmap image as sent, zlib-packed (a two-byte header, then deflate).</summary>
        public byte[] Lightmap { get; set; }

        /// <summary>A positive 0x3F1 list; any other count fails the read.</summary>
        public List<WaterMesh> Water { get; set; }

        /// <summary>From format version 5.</summary>
        public List<CameraAttractor> CameraAttractors { get; set; }

        #endregion
    }
}
