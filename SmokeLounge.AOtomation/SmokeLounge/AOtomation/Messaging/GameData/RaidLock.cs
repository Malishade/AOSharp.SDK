// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RaidLock.cs" company="SmokeLounge">
//   Copyright © 2013 SmokeLounge.
//   This program is free software. It comes without any warranty, to
//   the extent permitted by applicable law. You can redistribute it
//   and/or modify it under the terms of the Do What The Fuck You Want
//   To Public License, Version 2, as published by Sam Hocevar. See
//   http://www.wtfpl.net/ for more details.
// </copyright>
// <summary>
//   Defines the RaidLock type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SmokeLounge.AOtomation.Messaging.GameData
{
    /// <summary>
    /// One raid lock of RaidMessage's list, as the client keeps it (two int pairs and an int): its lock list
    /// prints Id as the lock's id (and looks its playfield name up by it), prints Value as it is and counts the
    /// time left from Expires.
    /// </summary>
    public class RaidLock
    {
        #region Public Properties

        public int Unknown1 { get; set; }

        public int Id { get; set; }

        public int Unknown2 { get; set; }

        public uint Value { get; set; }

        public int Expires { get; set; }

        #endregion
    }
}
