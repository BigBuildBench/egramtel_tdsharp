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
        public partial class Update : Object
        {
            /// <summary>
            /// A message was sent by an opened Web App, so the Web App needs to be closed
            /// </summary>
            public class UpdateWebAppMessageSent : Update
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "updateWebAppMessageSent";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Identifier of Web App launch
                /// </summary>
                [JsonConverter(typeof(Converter.Int64))]
                [JsonProperty("web_app_launch_id")]
                public long WebAppLaunchId { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd