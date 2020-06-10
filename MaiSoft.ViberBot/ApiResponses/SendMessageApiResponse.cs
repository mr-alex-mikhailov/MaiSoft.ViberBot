using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaiSoft.ViberBot.ApiResponses
{
    internal sealed class SendMessageApiResponse : BaseApiResponse
    {
        /// <summary>
        /// Unique ID of the message
        /// </summary>
        [JsonProperty("message_token")]
        public Int64 MessageToken { get; set; }
    }
}
