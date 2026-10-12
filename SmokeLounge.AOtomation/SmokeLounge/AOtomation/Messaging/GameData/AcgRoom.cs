// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AcgRoom.cs" company="SmokeLounge">
//   Copyright © 2013 SmokeLounge.
//   This program is free software. It comes without any warranty, to
//   the extent permitted by applicable law. You can redistribute it
//   and/or modify it under the terms of the Do What The Fuck You Want
//   To Public License, Version 2, as published by Sam Hocevar. See
//   http://www.wtfpl.net/ for more details.
// </copyright>
// <summary>
//   Defines the AcgRoom type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SmokeLounge.AOtomation.Messaging.GameData
{
    /// <summary>
    /// A generated building's room (BuildingRoomInfo_t, six bytes): the template's room, its floor (-16..16), its
    /// block on the grid (0..32 each way) and its quarter turns (0..3).
    /// </summary>
    public class AcgRoom
    {
        #region Public Properties

        public ushort RoomIndex { get; set; }

        public sbyte Floor { get; set; }

        public byte GridX { get; set; }

        public byte GridZ { get; set; }

        public byte Rotation { get; set; }

        public bool IsValid
        {
            get
            {
                return this.Floor >= -16 && this.Floor <= 16 && this.RoomIndex <= 10000 && this.GridX <= 0x20
                       && this.GridZ <= 0x20 && this.Rotation < 4;
            }
        }

        #endregion
    }
}
