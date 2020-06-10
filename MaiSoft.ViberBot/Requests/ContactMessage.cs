using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaiSoft.ViberBot
{
    /// <summary>
    /// Contact message
    /// </summary>
    public class ContactMessage : BaseMessage
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ContactMessage(UserInfo sender, String receiverId)
            : base(MessageTypeEnum.Contact, sender, receiverId) { }

        /// <summary>
        /// Constructor
        /// </summary>
        public ContactMessage(UserInfo sender, String[] receiverIds)
            : base(MessageTypeEnum.Contact, sender, receiverIds) { }

        /// <summary>
        /// Contact data
        /// </summary>
        [JsonProperty("contact")]
        public ContactInfo Contact { get; set; }
    }
}
