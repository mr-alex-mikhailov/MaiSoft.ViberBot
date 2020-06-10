using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaiSoft.ViberBot
{
    public class UserInfo
    {
        /// <summary>
        /// User’s Viber name
        /// </summary>
        [JsonProperty("name")]
        public String Name { get; set; }

        /// <summary>
        /// URL of the user’s avatar
        /// </summary>
        [JsonProperty("avatar")]
        public String AvatarUrl { get; set; }
    }
}
