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
        public partial class InternalLinkType : Object
        {
            /// <summary>
            /// The link can be used to login the current user on another device, but it must be scanned from QR-code using in-app camera. An alert similar to
            /// "This code can be used to allow someone to log in to your Telegram account. To confirm Telegram login, please go to Settings &gt; Devices &gt; Scan QR and scan the code" needs to be shown
            /// </summary>
            public class InternalLinkTypeQrCodeAuthentication : InternalLinkType
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "internalLinkTypeQrCodeAuthentication";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }


            }
        }
    }
}
// REUSE-IgnoreEnd