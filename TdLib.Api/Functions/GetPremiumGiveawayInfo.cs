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
        /// Returns information about a Telegram Premium giveaway
        /// </summary>
        public class GetPremiumGiveawayInfo : Function<PremiumGiveawayInfo>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getPremiumGiveawayInfo";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Identifier of the channel chat which started the giveaway
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_id")]
            public long ChatId { get; set; }

            /// <summary>
            /// Identifier of the giveaway or a giveaway winners message in the chat
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("message_id")]
            public long MessageId { get; set; }
        }

        /// <summary>
        /// Returns information about a Telegram Premium giveaway
        /// </summary>
        public static Task<PremiumGiveawayInfo> GetPremiumGiveawayInfoAsync(
            this Client client, long chatId = default, long messageId = default)
        {
            return client.ExecuteAsync(new GetPremiumGiveawayInfo
            {
                ChatId = chatId, MessageId = messageId
            });
        }
    }
}
// REUSE-IgnoreEnd