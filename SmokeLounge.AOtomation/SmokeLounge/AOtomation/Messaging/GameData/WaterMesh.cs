// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WaterMesh.cs" company="SmokeLounge">
//   Copyright © 2013 SmokeLounge.
//   This program is free software. It comes without any warranty, to
//   the extent permitted by applicable law. You can redistribute it
//   and/or modify it under the terms of the Do What The Fuck You Want
//   To Public License, Version 2, as published by Sam Hocevar. See
//   http://www.wtfpl.net/ for more details.
// </copyright>
// <summary>
//   Defines the WaterMesh type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SmokeLounge.AOtomation.Messaging.GameData
{
    using System.Collections.Generic;

    using AOSharp.Common.GameData;

    /// <summary>
    /// A water surface: its flags, its vertices and its triangles (three vertex indices each).
    /// </summary>
    public class WaterMesh
    {
        #region Constructors and Destructors

        public WaterMesh()
        {
            this.Vertices = new List<Vector3>();
            this.Triangles = new List<short>();
        }

        #endregion

        #region Public Properties

        public int Flags { get; set; }

        public List<Vector3> Vertices { get; set; }

        /// <summary>Three indices per triangle.</summary>
        public List<short> Triangles { get; set; }

        #endregion
    }
}
