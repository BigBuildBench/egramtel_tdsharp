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
            /// A forum topic has been created
            /// </summary>
            public class MessageForumTopicCreated : MessageContent
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "messageForumTopicCreated";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Name of the topic
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("name")]
                public string Name { get; set; }

                /// <summary>
                /// Icon of the topic
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("icon")]
                public ForumTopicIcon Icon { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd