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
            /// Contains the content of a message
            /// </summary>
            public class MessageText : MessageContent
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "messageText";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Text of the message
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("text")]
                public FormattedText Text { get; set; }

                /// <summary>
                /// A link preview attached to the message; may be null
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("web_page")]
                public WebPage WebPage { get; set; }

                /// <summary>
                /// Options which were used for generation of the link preview; may be null if default options were used
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("link_preview_options")]
                public LinkPreviewOptions LinkPreviewOptions { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd