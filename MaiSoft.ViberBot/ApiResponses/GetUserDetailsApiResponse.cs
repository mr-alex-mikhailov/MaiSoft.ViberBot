using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaiSoft.ViberBot.ApiResponses
{
    internal sealed class GetUserDetailsApiResponse : BaseApiResponse
    {
        /// <summary>
        /// Unique id of the message	
        /// </summary>
        [JsonProperty("message_token")]
        public Int64 MessageToken { get; set; }

        /// <summary>
        /// User details.
        /// </summary>
        [JsonProperty("user")]
        public UserDetails UserDetails { get; set; }
    }
}
