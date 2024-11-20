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
        public partial class ChatType : Object
        {
            /// <summary>
            /// A secret chat with a user
            /// </summary>
            public class ChatTypeSecret : ChatType
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "chatTypeSecret";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Secret chat identifier
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("secret_chat_id")]
                public int SecretChatId { get; set; }

                /// <summary>
                /// User identifier of the other user in the secret chat
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("user_id")]
                public long UserId { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd