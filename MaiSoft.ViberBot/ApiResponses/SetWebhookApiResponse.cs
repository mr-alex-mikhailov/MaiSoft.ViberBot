using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaiSoft.ViberBot.ApiResponses
{
    internal sealed class SetWebhookApiResponse : BaseApiResponse
    {
        /// <summary>
        /// List of event types you will receive a callback for. Should return the same values sent in the request
        /// </summary>
        [JsonProperty("event_types")]
        public IEnumerable<EventTypeEnum> EventTypes { get; set; }
    }
}
