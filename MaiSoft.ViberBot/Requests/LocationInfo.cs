using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaiSoft.ViberBot
{
    /// <summary>
    /// Location data
    /// </summary>
    public class LocationInfo
    {
        /// <summary>
        /// Latitude
        /// </summary>
        [JsonProperty("lat")]
        public Double Latitude { get; set; }

        /// <summary>
        /// Longitude
        /// </summary>
        [JsonProperty("lon")]
        public Double Longitude { get; set; }
    }
}
