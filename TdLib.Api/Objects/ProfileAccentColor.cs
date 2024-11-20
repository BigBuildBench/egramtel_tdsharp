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
        /// Contains information about supported accent color for user profile photo background
        /// </summary>
        public partial class ProfileAccentColor : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "profileAccentColor";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Profile accent color identifier
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("id")]
            public int Id { get; set; }

            /// <summary>
            /// Accent colors expected to be used in light themes
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("light_theme_colors")]
            public ProfileAccentColors LightThemeColors { get; set; }

            /// <summary>
            /// Accent colors expected to be used in dark themes
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("dark_theme_colors")]
            public ProfileAccentColors DarkThemeColors { get; set; }

            /// <summary>
            /// The minimum chat boost level required to use the color in a supergroup chat
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("min_supergroup_chat_boost_level")]
            public int MinSupergroupChatBoostLevel { get; set; }

            /// <summary>
            /// The minimum chat boost level required to use the color in a channel chat
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("min_channel_chat_boost_level")]
            public int MinChannelChatBoostLevel { get; set; }
        }
    }
}
// REUSE-IgnoreEnd