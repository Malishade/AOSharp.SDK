// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AcgItem.cs" company="SmokeLounge">
//   Copyright © 2013 SmokeLounge.
//   This program is free software. It comes without any warranty, to
//   the extent permitted by applicable law. You can redistribute it
//   and/or modify it under the terms of the Do What The Fuck You Want
//   To Public License, Version 2, as published by Sam Hocevar. See
//   http://www.wtfpl.net/ for more details.
// </copyright>
// <summary>
//   Defines the AcgItem type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SmokeLounge.AOtomation.Messaging.GameData
{
    /// <summary>
    /// The client's ACGItem_t, as its reader leaves it: a low id, a high id (the low id when 0), a quality (masked to
    /// 0x1ff when above it) and an int after it.
    /// </summary>
    public class AcgItem
    {
        #region Public Properties

        public int LowId { get; set; }

        public int HighId { get; set; }

        public int Quality { get; set; }

        public int Unknown1 { get; set; }

        #endregion
    }
}
