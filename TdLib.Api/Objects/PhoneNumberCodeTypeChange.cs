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
        public partial class PhoneNumberCodeType : Object
        {
            /// <summary>
            /// Describes type of the request for which a code is sent to a phone number
            /// </summary>
            public class PhoneNumberCodeTypeChange : PhoneNumberCodeType
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "phoneNumberCodeTypeChange";

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