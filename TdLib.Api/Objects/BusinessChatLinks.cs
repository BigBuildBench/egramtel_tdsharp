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
        /// Contains a list of business chat links created by the user
        /// </summary>
        public partial class BusinessChatLinks : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "businessChatLinks";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// List of links
            /// </summary>
            [JsonProperty("links", ItemConverterType = typeof(Converter))]
            public BusinessChatLink[] Links { get; set; }
        }
    }
}
// REUSE-IgnoreEnd