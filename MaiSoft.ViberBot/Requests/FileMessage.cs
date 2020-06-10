using Newtonsoft.Json;
using System;

namespace MaiSoft.ViberBot
{
    /// <summary>
    /// File message
    /// </summary>
    public class FileMessage : BaseMessage
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public FileMessage(UserInfo sender, String receiverId)
            : base(MessageTypeEnum.File, sender, receiverId) { }

        /// <summary>
        /// Constructor
        /// </summary>
        public FileMessage(UserInfo sender, String[] receiverIds)
            : base(MessageTypeEnum.File, sender, receiverIds) { }

        /// <summary>
        /// File URL
        /// </summary>
        [JsonProperty("media")]
        public String Url { get; set; }

        /// <summary>
        /// File size in bytes (max size 50 MB)
        /// </summary>
        [JsonProperty("size")]
        public Int32 Size { get; set; }

        /// <summary>
        /// File name (max 256 characters). Should include extension
        /// </summary>
        [JsonProperty("file_name")]
        public String FileName { get; set; }
    }
}
