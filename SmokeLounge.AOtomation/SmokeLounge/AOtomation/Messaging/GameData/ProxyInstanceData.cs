// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProxyInstanceData.cs" company="SmokeLounge">
//   Copyright © 2013 SmokeLounge.
//   This program is free software. It comes without any warranty, to
//   the extent permitted by applicable law. You can redistribute it
//   and/or modify it under the terms of the Do What The Fuck You Want
//   To Public License, Version 2, as published by Sam Hocevar. See
//   http://www.wtfpl.net/ for more details.
// </copyright>
// <summary>
//   Defines the ProxyInstanceData type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SmokeLounge.AOtomation.Messaging.GameData
{
    using AOSharp.Common.GameData;

    /// <summary>
    /// The block a 0xC77B proxy instance carries before its dynels.
    /// </summary>
    public class ProxyInstanceData
    {
        #region Public Properties

        public int Unknown1 { get; set; }

        public Identity Unknown2 { get; set; }

        public int Unknown3 { get; set; }

        public Vector3 Unknown4 { get; set; }

        public int Unknown5 { get; set; }

        public int Unknown6 { get; set; }

        public float Unknown7 { get; set; }

        public int Unknown8 { get; set; }

        public int Unknown9 { get; set; }

        #endregion
    }
}
