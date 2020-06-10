using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaiSoft.ViberBot
{
    /// <summary>
    /// Text message
    /// </summary>
    public class TextMessage : BaseMessage
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public TextMessage(UserInfo sender, String receiverId)
            : base(MessageTypeEnum.Text, sender, receiverId) { }

        /// <summary>
        /// Constructor
        /// </summary>
        public TextMessage(UserInfo sender, String[] receiverIds)
            : base(MessageTypeEnum.Text, sender, receiverIds) { }

        /// <summary>
        /// Text
        /// </summary>
        [JsonProperty("text")]
        public String Text { get; set; }
    }
}
