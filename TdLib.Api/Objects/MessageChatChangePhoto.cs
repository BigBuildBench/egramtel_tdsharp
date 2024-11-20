using System;
using Newtonsoft.Json;

// REUSE-IgnoreStart
namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class MessageContent : Object
        {
            /// <summary>
            /// An updated chat photo
            /// </summary>
            public class MessageChatChangePhoto : MessageContent
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "messageChatChangePhoto";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// New chat photo
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("photo")]
                public ChatPhoto Photo { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd