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
        /// Contains size of downloaded prefix of a file
        /// </summary>
        public partial class FileDownloadedPrefixSize : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "fileDownloadedPrefixSize";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// The prefix size, in bytes
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("size")]
            public long Size { get; set; }
        }
    }
}
// REUSE-IgnoreEnd