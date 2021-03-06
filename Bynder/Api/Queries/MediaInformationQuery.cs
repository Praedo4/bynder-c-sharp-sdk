﻿// Copyright (c) Bynder. All rights reserved.
// Licensed under the MIT License. See LICENSE file in the project root for full license information.

namespace Bynder.Api.Queries
{
    /// <summary>
    /// Query used to get media information including media items
    /// </summary>
    public class MediaInformationQuery
    {
        /// <summary>
        /// Id of the media from which we want to retrieve information
        /// </summary>
        public string MediaId { get; set; }

        /// <summary>
        /// This property has to be set to 1 so API returns media items
        /// </summary>
        [APIField("versions")]
        public int Versions { get; set; } = 1;
    }
}
