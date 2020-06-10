using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaiSoft.ViberBot
{
    public class AccountInfo
    {
        /// <summary>
        /// Unique numeric id of the account
        /// </summary>
        [JsonProperty("id")]
        public String Id { get; set; }

        /// <summary>
        /// Account name (max 75 characters)
        /// </summary>
        [JsonProperty("name")]
        public String Name { get; set; }

        /// <summary>
        /// Unique URI of the Account
        /// </summary>
        [JsonProperty("uri")]
        public String Uri { get; set; }

        /// <summary>
        /// Account icon URL (JPEG, 720x720, size no more than 512 kb)
        /// </summary>
        [JsonProperty("icon")]
        public String IconUrl { get; set; }

        /// <summary>
        /// Conversation background URL (JPEG, max 1920x1920, size no more than 512 kb)
        /// </summary>
        [JsonProperty("background")]
        public String BackgroundUrl { get; set; }

        /// <summary>
        /// Account category
        /// </summary>
        [JsonProperty("category")]
        public String Category { get; set; }

        /// <summary>
        /// Account sub-category
        /// </summary>
        [JsonProperty("subcategory")]
        public String Subcategory { get; set; }

        /// <summary>
        /// Account location (coordinates). Will be used for finding accounts near me
        /// </summary>
        [JsonProperty("location")]
        public LocationInfo Location { get; set; }

        /// <summary>
        /// Account two-letters country code - ISO ALPHA-2 Code
        /// </summary>
        [JsonProperty("country")]
        public String CountryCode { get; set; }

        /// <summary>
        /// Account registered webhook
        /// </summary>
        [JsonProperty("webhook")]
        public String Webhook { get; set; }

        /// <summary>
        /// Account registered events – as set by set_webhook request
        /// </summary>
        [JsonProperty("event_types")]
        public IEnumerable<EventTypeEnum> EventTypes { get; set; }

        /// <summary>
        /// Number of subscribers
        /// </summary>
        [JsonProperty("subscribers_count")]
        public Int64 SubscribersCount { get; set; }
    }
}
