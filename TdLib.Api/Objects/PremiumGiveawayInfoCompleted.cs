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
        public partial class PremiumGiveawayInfo : Object
        {
            /// <summary>
            /// Describes a completed giveaway
            /// </summary>
            public class PremiumGiveawayInfoCompleted : PremiumGiveawayInfo
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "premiumGiveawayInfoCompleted";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Point in time (Unix timestamp) when the giveaway was created
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("creation_date")]
                public int CreationDate { get; set; }

                /// <summary>
                /// Point in time (Unix timestamp) when the winners were selected. May be bigger than winners selection date specified in parameters of the giveaway
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("actual_winners_selection_date")]
                public int ActualWinnersSelectionDate { get; set; }

                /// <summary>
                /// True, if the giveaway was canceled and was fully refunded
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("was_refunded")]
                public bool WasRefunded { get; set; }

                /// <summary>
                /// Number of winners in the giveaway
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("winner_count")]
                public int WinnerCount { get; set; }

                /// <summary>
                /// Number of winners, which activated their gift codes
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("activation_count")]
                public int ActivationCount { get; set; }

                /// <summary>
                /// Telegram Premium gift code that was received by the current user; empty if the user isn't a winner in the giveaway
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("gift_code")]
                public string GiftCode { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd