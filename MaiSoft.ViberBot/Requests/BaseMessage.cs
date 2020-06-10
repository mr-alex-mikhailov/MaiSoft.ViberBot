using Newtonsoft.Json;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Converters;

namespace MaiSoft.ViberBot
{
    /// <summary>
    /// Message base data
    /// </summary>
    public abstract class BaseMessage
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="messageType">Message type</param>
        /// <param name="sender">Sender data</param>
        /// <param name="receiverId">Unique Viber user id</param>
        protected internal BaseMessage(MessageTypeEnum messageType, UserInfo sender, String receiverId)
            : this(messageType, sender, new[] { receiverId }) { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="messageType">Message type</param>
        /// <param name="sender">Sender data</param>
        /// <param name="receiverIds">Unique Viber user ids</param>
        protected internal BaseMessage(MessageTypeEnum messageType, UserInfo sender, String[] receiverIds)
        {
            if (sender == null)
                throw new ArgumentNullException(nameof(sender));

            if (String.IsNullOrWhiteSpace(sender.Name))
                throw new ArgumentException("Sender Name cannot be empty");

            if (receiverIds == null)
                throw new ArgumentNullException(nameof(receiverIds));

            var nonEmptyReceiverIds = receiverIds.Where(p => !String.IsNullOrWhiteSpace(p));

            if (nonEmptyReceiverIds.Count() == 0)
                throw new ArgumentException("Receiver Ids cannot be empty", nameof(receiverIds));

            if (nonEmptyReceiverIds.Count() > ViberBotClient.MaxBroadcastMessageReceivers)
                throw new ArgumentException($"Number of receivers exceeded maximum of {ViberBotClient.MaxBroadcastMessageReceivers}", nameof(receiverIds));

            MessageType = messageType;
            Sender = sender;
            ReceiverIds = nonEmptyReceiverIds;
            IsBroadcasting = nonEmptyReceiverIds.Count() > 1;
        }

        /// <summary>
        /// Message type
        /// </summary>
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public MessageTypeEnum MessageType { get; }

        /// <summary>
        /// Indicates whether the message is broadcasting
        /// </summary>
        [JsonIgnore]
        public Boolean IsBroadcasting { get; }

        /// <summary>
        /// Sender data
        /// </summary>
        [JsonProperty("sender")]
        public UserInfo Sender { get; }

        /// <summary>
        /// Allow the account to track messages and user's replies. Sent tracking_data value will be passed back with user's reply
        /// </summary>
        [JsonProperty("tracking_data")]
        public String TrackingData { get; set; }

        /// <summary>
        /// Minimal API version required by clients for this message (default 1)
        /// </summary>
        [JsonProperty("min_api_version")]
        public Int32? MinApiVersion { get; set; }

        /// <summary>
        /// Unique Viber receiver ids
        /// </summary>
        [JsonIgnore]
        public IEnumerable<String> ReceiverIds { get; }

        /// <summary>
        /// Unique Viber user id. Used to send message to single user
        /// </summary>
        [JsonProperty("receiver")]
        internal String InternalReceiverId
        {
            get { return ReceiverIds.Count() == 1 ? ReceiverIds.FirstOrDefault() : null; }
        }

        /// <summary>
        /// Unique Viber user ids. Used to send broadcast messages
        /// </summary>
        [JsonProperty("broadcast_list")]
        internal IEnumerable<String> InternalReceiverIds
        {
            get { return ReceiverIds.Count() > 1 ? ReceiverIds : null; }
        }
    }
}
