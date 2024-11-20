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
        /// Represents a tag used in Saved Messages or a Saved Messages topic
        /// </summary>
        public partial class SavedMessagesTag : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "savedMessagesTag";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// The tag
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("tag")]
            public ReactionType Tag { get; set; }

            /// <summary>
            /// Label of the tag; 0-12 characters. Always empty if the tag is returned for a Saved Messages topic
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("label")]
            public string Label { get; set; }

            /// <summary>
            /// Number of times the tag was used; may be 0 if the tag has non-empty label
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("count")]
            public int Count { get; set; }
        }
    }
}
// REUSE-IgnoreEnd