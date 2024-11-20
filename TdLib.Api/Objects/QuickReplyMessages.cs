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
        /// <summary>
        /// Contains a list of quick reply messages
        /// </summary>
        public partial class QuickReplyMessages : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "quickReplyMessages";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// List of quick reply messages; messages may be null
            /// </summary>
            [JsonProperty("messages", ItemConverterType = typeof(Converter))]
            public QuickReplyMessage[] Messages { get; set; }
        }
    }
}
// REUSE-IgnoreEnd