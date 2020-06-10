using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaiSoft.ViberBot
{
    /// <summary>
    /// URL message
    /// </summary>
    public class UrlMessage : BaseMessage
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public UrlMessage(UserInfo sender, String receiverId)
            : base(MessageTypeEnum.Url, sender, receiverId) { }

        /// <summary>
        /// Constructor
        /// </summary>
        public UrlMessage(UserInfo sender, String[] receiverIds)
            : base(MessageTypeEnum.Url, sender, receiverIds) { }

        /// <summary>
        /// URL (max 2000 characters)
        /// </summary>
        [JsonProperty("media")]
        public String Url { get; set; }
    }
}
