using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaiSoft.ViberBot
{
    public class UserDetails : UserInfo
    {
        /// <summary>
        /// Unique Viber user id
        /// </summary>
        [JsonProperty("id")]
        public String Id { get; set; }

        /// <summary>
        /// User’s two-letters country code - ISO ALPHA-2 Code
        /// </summary>
        [JsonProperty("country")]
        public String CountryCode { get; set; }

        /// <summary>
        /// User’s phone language code (ISO 639-1). Will be returned according to the device language
        /// </summary>
        [JsonProperty("language")]
        public String LanguageCode { get; set; }

        /// <summary>
        /// Max API version, matching the most updated user’s device (Currently only 1. Additional versions will be added in the future)
        /// </summary>
        [JsonProperty("api_version")]
        public Double ApiVersion { get; set; }

        /// <summary>
        /// The operating system type and version of the user’s primary device.
        /// </summary>
        [JsonProperty("primary_device_os")]
        public String PrimaryDeviceOS { get; set; }

        /// <summary>
        /// The Viber version installed on the user’s primary device
        /// </summary>
        [JsonProperty("viber_version")]
        public String ViberVersion { get; set; }

        /// <summary>
        /// Mobile country code
        /// </summary>
        [JsonProperty("mcc")]
        public Int32 MobileCountryCode { get; set; }

        /// <summary>
        /// Mobile network code
        /// </summary>
        [JsonProperty("mnc")]
        public Int32 MobileNetworkCode { get; set; }

        /// <summary>
        /// The user’s device type
        /// </summary>
        [JsonProperty("device_type")]
        public String DeviceType { get; set; }
    }
}
