// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GridDestination.cs" company="SmokeLounge">
//   Copyright © 2013 SmokeLounge.
//   This program is free software. It comes without any warranty, to
//   the extent permitted by applicable law. You can redistribute it
//   and/or modify it under the terms of the Do What The Fuck You Want
//   To Public License, Version 2, as published by Sam Hocevar. See
//   http://www.wtfpl.net/ for more details.
// </copyright>
// <summary>
//   Defines the GridDestination type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using AOSharp.Common.GameData;

namespace SmokeLounge.AOtomation.Messaging.GameData
{
    /// <summary>A GridDestinationList_t entry of an <see cref="InfoPacket"/>.</summary>
    public class GridDestination
    {
        #region Public Properties

        public int Unknown1 { get; set; }

        public Identity Identity { get; set; }

        public string Name { get; set; }

        public int Unknown2 { get; set; }

        public int Unknown3 { get; set; }

        #endregion
    }
}
