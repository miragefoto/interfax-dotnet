﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace InterFAX.Api.Dtos
{
    /// <summary>
    /// Supported page sizes.
    /// </summary>
    public enum PageSize
    {
        /// <summary>
        /// A4 page size (common outside North America)
        /// </summary>
        A4,

        /// <summary>
        /// Letter page size (common in North America)
        /// </summary>
        Letter,

        /// <summary>
        /// Legal page size (common in North America)
        /// </summary>
        Legal,

        /// <summary>
        /// B4 page size (used mainly in Japan)
        /// </summary>
        B4
    }
}
