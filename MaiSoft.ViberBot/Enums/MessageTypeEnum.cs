using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace MaiSoft.ViberBot
{
    /// <summary>
    /// Message types
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MessageTypeEnum
    {
        [EnumMember(Value = "text")]
        Text,

        [EnumMember(Value = "picture")]
        Picture,

        [EnumMember(Value = "video")]
        Video,

        [EnumMember(Value = "file")]
        File,

        [EnumMember(Value = "contact")]
        Contact,

        [EnumMember(Value = "location")]
        Location,

        [EnumMember(Value = "url")]
        Url,

        [EnumMember(Value = "sticker")]
        Sticker

        //[EnumMember(Value = "rich_media")]
        //RichMedia
    }
}
