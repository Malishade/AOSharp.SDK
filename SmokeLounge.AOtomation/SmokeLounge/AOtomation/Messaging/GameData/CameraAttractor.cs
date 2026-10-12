// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CameraAttractor.cs" company="SmokeLounge">
//   Copyright © 2013 SmokeLounge.
//   This program is free software. It comes without any warranty, to
//   the extent permitted by applicable law. You can redistribute it
//   and/or modify it under the terms of the Do What The Fuck You Want
//   To Public License, Version 2, as published by Sam Hocevar. See
//   http://www.wtfpl.net/ for more details.
// </copyright>
// <summary>
//   Defines the CameraAttractor type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SmokeLounge.AOtomation.Messaging.GameData
{
    using AOSharp.Common.GameData;

    /// <summary>
    /// A camera attractor: a position, an orientation, a target (from format version 6; the position before) and a
    /// range.
    /// </summary>
    public class CameraAttractor
    {
        #region Public Properties

        public Vector3 Position { get; set; }

        public Quaternion Orientation { get; set; }

        public Vector3 Target { get; set; }

        public float Range { get; set; }

        #endregion
    }
}
