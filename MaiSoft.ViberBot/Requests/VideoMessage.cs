using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaiSoft.ViberBot
{
    /// <summary>
    /// Video message
    /// </summary>
    public class VideoMessage : BaseMessage
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public VideoMessage(UserInfo sender, String receiverId)
            : base(MessageTypeEnum.Video, sender, receiverId) { }

        /// <summary>
        /// Constructor
        /// </summary>
        public VideoMessage(UserInfo sender, String[] receiverIds)
            : base(MessageTypeEnum.Video, sender, receiverIds) { }

        /// <summary>
        /// Video URL (max size 50 MB). Only MP4 and H264 are supported
        /// </summary>
        [JsonProperty("media")]
        public String Url { get; set; }

        /// <summary>
        /// Video size
        /// </summary>
        [JsonProperty("size")]
        public Int32 Size { get; set; }

        /// <summary>
        /// Video duration in seconds; will be displayed to the receiver (max 180 seconds)
        /// </summary>
        [JsonProperty("duration")]
        public Int32? Duration { get; set; }

        /// <summary>
        /// Thumbnail URL (max size 100 kb). Recommended: 400x400. Only JPEG format is supported
        /// </summary>
        [JsonProperty("thumbnail")]
        public String ThumbnailUrl { get; set; }
    }
}
