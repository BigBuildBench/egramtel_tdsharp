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
        /// Returns information about features, available to Premium users
        /// </summary>
        public class GetPremiumFeatures : Function<PremiumFeatures>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getPremiumFeatures";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Source of the request; pass null if the method is called from some non-standard source
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("source")]
            public PremiumSource Source { get; set; }
        }

        /// <summary>
        /// Returns information about features, available to Premium users
        /// </summary>
        public static Task<PremiumFeatures> GetPremiumFeaturesAsync(
            this Client client, PremiumSource source = default)
        {
            return client.ExecuteAsync(new GetPremiumFeatures
            {
                Source = source
            });
        }
    }
}
// REUSE-IgnoreEnd