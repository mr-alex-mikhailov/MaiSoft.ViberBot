using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaiSoft.ViberBot
{
    /// <summary>
    /// Location message
    /// </summary>
    public class LocationMessage : BaseMessage
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public LocationMessage(UserInfo sender, String receiverId)
            : base(MessageTypeEnum.Location, sender, receiverId) { }

        /// <summary>
        /// Constructor
        /// </summary>
        public LocationMessage(UserInfo sender, String[] receiverIds)
            : base(MessageTypeEnum.Location, sender, receiverIds) { }

        /// <summary>
        /// Location data
        /// </summary>
        [JsonProperty("location")]
        public LocationInfo Location { get; set; }
    }
}
