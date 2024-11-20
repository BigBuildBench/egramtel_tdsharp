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
        /// Represents a file
        /// </summary>
        public partial class File : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "file";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Unique file identifier
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("id")]
            public int Id { get; set; }

            /// <summary>
            /// File size, in bytes; 0 if unknown
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("size")]
            public long Size { get; set; }

            /// <summary>
            /// Approximate file size in bytes in case the exact file size is unknown. Can be used to show download/upload progress
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("expected_size")]
            public long ExpectedSize { get; set; }

            /// <summary>
            /// Information about the local copy of the file
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("local")]
            public LocalFile Local { get; set; }

            /// <summary>
            /// Information about the remote copy of the file
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("remote")]
            public RemoteFile Remote { get; set; }
        }
    }
}
// REUSE-IgnoreEnd