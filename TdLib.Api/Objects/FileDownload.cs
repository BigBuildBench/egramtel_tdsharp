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
        /// Describes a file added to file download list
        /// </summary>
        public partial class FileDownload : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "fileDownload";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// File identifier
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("file_id")]
            public int FileId { get; set; }

            /// <summary>
            /// The message with the file
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("message")]
            public Message Message { get; set; }

            /// <summary>
            /// Point in time (Unix timestamp) when the file was added to the download list
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("add_date")]
            public int AddDate { get; set; }

            /// <summary>
            /// Point in time (Unix timestamp) when the file downloading was completed; 0 if the file downloading isn't completed
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("complete_date")]
            public int CompleteDate { get; set; }

            /// <summary>
            /// True, if downloading of the file is paused
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_paused")]
            public bool IsPaused { get; set; }
        }
    }
}
// REUSE-IgnoreEnd