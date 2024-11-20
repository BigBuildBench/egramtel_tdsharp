using System;
using System.Threading.Tasks;
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
        /// Changes privacy settings for new chat creation; can be used only if getOption("can_set_new_chat_privacy_settings")
        /// </summary>
        public class SetNewChatPrivacySettings : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "setNewChatPrivacySettings";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// New settings
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("settings")]
            public NewChatPrivacySettings Settings { get; set; }
        }

        /// <summary>
        /// Changes privacy settings for new chat creation; can be used only if getOption("can_set_new_chat_privacy_settings")
        /// </summary>
        public static Task<Ok> SetNewChatPrivacySettingsAsync(
            this Client client, NewChatPrivacySettings settings = default)
        {
            return client.ExecuteAsync(new SetNewChatPrivacySettings
            {
                Settings = settings
            });
        }
    }
}
// REUSE-IgnoreEnd