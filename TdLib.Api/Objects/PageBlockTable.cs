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
        public partial class PageBlock : Object
        {
            /// <summary>
            /// A table
            /// </summary>
            public class PageBlockTable : PageBlock
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "pageBlockTable";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Table caption
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("caption")]
                public RichText Caption { get; set; }

                /// <summary>
                /// Table cells
                /// </summary>
                [JsonProperty("cells", ItemConverterType = typeof(Converter))]
                public PageBlockTableCell[][] Cells { get; set; }

                /// <summary>
                /// True, if the table is bordered
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_bordered")]
                public bool IsBordered { get; set; }

                /// <summary>
                /// True, if the table is striped
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_striped")]
                public bool IsStriped { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd