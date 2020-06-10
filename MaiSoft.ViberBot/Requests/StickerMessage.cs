using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaiSoft.ViberBot
{
    /// <summary>
    /// Sticker message
    /// </summary>
    public class StickerMessage : BaseMessage
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public StickerMessage(UserInfo sender, String receiverId)
            : base(MessageTypeEnum.Sticker, sender, receiverId) { }

        /// <summary>
        /// Constructor
        /// </summary>
        public StickerMessage(UserInfo sender, String[] receiverIds)
            : base(MessageTypeEnum.Sticker, sender, receiverIds) { }

        /// <summary>
        /// Unique Viber sticker ID
        /// </summary>
        [JsonProperty("sticker_id")]
        public String StickerId { get; set; }
    }
}
