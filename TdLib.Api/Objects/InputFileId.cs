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
        public partial class InputFile : Object
        {
            /// <summary>
            /// Points to a file
            /// </summary>
            public class InputFileId : InputFile
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "inputFileId";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Unique file identifier
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("id")]
                public int Id { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd