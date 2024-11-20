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
        /// Describes autosave settings
        /// </summary>
        public partial class AutosaveSettings : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "autosaveSettings";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Default autosave settings for private chats
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("private_chat_settings")]
            public ScopeAutosaveSettings PrivateChatSettings { get; set; }

            /// <summary>
            /// Default autosave settings for basic group and supergroup chats
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("group_settings")]
            public ScopeAutosaveSettings GroupSettings { get; set; }

            /// <summary>
            /// Default autosave settings for channel chats
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("channel_settings")]
            public ScopeAutosaveSettings ChannelSettings { get; set; }

            /// <summary>
            /// Autosave settings for specific chats
            /// </summary>
            [JsonProperty("exceptions", ItemConverterType = typeof(Converter))]
            public AutosaveSettingsException[] Exceptions { get; set; }
        }
    }
}
// REUSE-IgnoreEnd