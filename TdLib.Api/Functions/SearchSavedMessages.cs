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
        /// Searches for messages tagged by the given reaction and with the given words in the Saved Messages chat; for Telegram Premium users only.
        /// Returns the results in reverse chronological order, i.e. in order of decreasing message_id
        /// For optimal performance, the number of returned messages is chosen by TDLib and can be smaller than the specified limit
        /// </summary>
        public class SearchSavedMessages : Function<FoundChatMessages>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "searchSavedMessages";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// If not 0, only messages in the specified Saved Messages topic will be considered; pass 0 to consider all messages
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("saved_messages_topic_id")]
            public long SavedMessagesTopicId { get; set; }

            /// <summary>
            /// Tag to search for; pass null to return all suitable messages
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("tag")]
            public ReactionType Tag { get; set; }

            /// <summary>
            /// Query to search for
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("query")]
            public string Query { get; set; }

            /// <summary>
            /// Identifier of the message starting from which messages must be fetched; use 0 to get results from the last message
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("from_message_id")]
            public long FromMessageId { get; set; }

            /// <summary>
            /// Specify 0 to get results from exactly the message from_message_id or a negative offset to get the specified message and some newer messages
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("offset")]
            public int Offset { get; set; }

            /// <summary>
            /// The maximum number of messages to be returned; must be positive and can't be greater than 100. If the offset is negative, the limit must be greater than -offset.
            /// For optimal performance, the number of returned messages is chosen by TDLib and can be smaller than the specified limit
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("limit")]
            public int Limit { get; set; }
        }

        /// <summary>
        /// Searches for messages tagged by the given reaction and with the given words in the Saved Messages chat; for Telegram Premium users only.
        /// Returns the results in reverse chronological order, i.e. in order of decreasing message_id
        /// For optimal performance, the number of returned messages is chosen by TDLib and can be smaller than the specified limit
        /// </summary>
        public static Task<FoundChatMessages> SearchSavedMessagesAsync(
            this Client client, long savedMessagesTopicId = default, ReactionType tag = default, string query = default, long fromMessageId = default, int offset = default, int limit = default)
        {
            return client.ExecuteAsync(new SearchSavedMessages
            {
                SavedMessagesTopicId = savedMessagesTopicId, Tag = tag, Query = query, FromMessageId = fromMessageId, Offset = offset, Limit = limit
            });
        }
    }
}
// REUSE-IgnoreEnd