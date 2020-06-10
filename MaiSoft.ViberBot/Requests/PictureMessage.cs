using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaiSoft.ViberBot
{
    /// <summary>
    /// Picture message
    /// </summary>
    public class PictureMessage : BaseMessage
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public PictureMessage(UserInfo sender, String receiverId)
            : base(MessageTypeEnum.Picture, sender, receiverId) { }

        /// <summary>
        /// Constructor
        /// </summary>
        public PictureMessage(UserInfo sender, String[] receiverIds)
            : base(MessageTypeEnum.Picture, sender, receiverIds) { }

        /// <summary>
        /// URL of the image (JPEG only) (max size 1 MB). Other image formats as well as animated GIFs can be sent as URL messages or file messages
        /// </summary>
        [JsonProperty("media")]
        public String Url { get; set; }

        /// <summary>
        /// Description of the photo (max 120 characters). Can be an empty string if irrelevant
        /// </summary>
        [JsonProperty("text")]
        public String Description { get; set; }

        /// <summary>
        /// URL of a reduced size image (JPEG) (max size 100 kb. Recommended: 400x400. Only JPEG format is supported)
        /// </summary>
        [JsonProperty("thumbnail")]
        public String ThumbnailUrl { get; set; }
    }
}
