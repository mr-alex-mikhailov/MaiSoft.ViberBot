using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaiSoft.ViberBot
{
    /// <summary>
    /// Contact data
    /// </summary>
    public class ContactInfo
    {
        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("name")]
        public String Name { get; set; }

        /// <summary>
        /// Phone number
        /// </summary>
        [JsonProperty("phone_number")]
        public String PhoneNumber { get; set; }
    }
}
