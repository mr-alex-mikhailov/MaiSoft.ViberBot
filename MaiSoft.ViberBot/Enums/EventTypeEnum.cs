using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace MaiSoft.ViberBot
{
    /// <summary>
    /// Callback event types
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EventTypeEnum
    {
        [EnumMember(Value = "subscribed")]
        Subscribed,

        [EnumMember(Value = "unsubscribed")]
        Unsubscribed,

        [EnumMember(Value = "conversation_started")]
        ConversationStarted,

        [EnumMember(Value = "delivered")]
        Delivered,

        [EnumMember(Value = "seen")]
        Seen,

        [EnumMember(Value = "failed")]
        Failed,

        [EnumMember(Value = "webhook")]
        Webhook,

        [EnumMember(Value = "action")]
        Action,

        [EnumMember(Value = "message")]
        Message
    }
}
