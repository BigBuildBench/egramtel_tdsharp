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
        public partial class FirebaseAuthenticationSettings : Object
        {
            /// <summary>
            /// Settings for Firebase Authentication in the official iOS application
            /// </summary>
            public class FirebaseAuthenticationSettingsIos : FirebaseAuthenticationSettings
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "firebaseAuthenticationSettingsIos";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Device token from Apple Push Notification service
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("device_token")]
                public string DeviceToken { get; set; }

                /// <summary>
                /// True, if App Sandbox is enabled
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_app_sandbox")]
                public bool IsAppSandbox { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd