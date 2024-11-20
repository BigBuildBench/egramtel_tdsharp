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
            /// A message with information about an ended call
            /// </summary>
            public class MessageCall : MessageContent
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "messageCall";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// True, if the call was a video call
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_video")]
                public bool IsVideo { get; set; }

                /// <summary>
                /// Reason why the call was discarded
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("discard_reason")]
                public CallDiscardReason DiscardReason { get; set; }

                /// <summary>
                /// Call duration, in seconds
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("duration")]
                public int Duration { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd