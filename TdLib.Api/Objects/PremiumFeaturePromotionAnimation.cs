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
        /// Describes a promotion animation for a Premium feature
        /// </summary>
        public partial class PremiumFeaturePromotionAnimation : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "premiumFeaturePromotionAnimation";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Premium feature
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("feature")]
            public PremiumFeature Feature { get; set; }

            /// <summary>
            /// Promotion animation for the feature
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("animation")]
            public Animation Animation { get; set; }
        }
    }
}
// REUSE-IgnoreEnd