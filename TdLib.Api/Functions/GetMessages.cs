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
        /// Returns information about messages. If a message is not found, returns null on the corresponding position of the result
        /// </summary>
        public class GetMessages : Function<Messages>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getMessages";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Identifier of the chat the messages belong to
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_id")]
            public long ChatId { get; set; }

            /// <summary>
            /// Identifiers of the messages to get
            /// </summary>
            [JsonProperty("message_ids", ItemConverterType = typeof(Converter))]
            public long[] MessageIds { get; set; }
        }

        /// <summary>
        /// Returns information about messages. If a message is not found, returns null on the corresponding position of the result
        /// </summary>
        public static Task<Messages> GetMessagesAsync(
            this Client client, long chatId = default, long[] messageIds = default)
        {
            return client.ExecuteAsync(new GetMessages
            {
                ChatId = chatId, MessageIds = messageIds
            });
        }
    }
}
// REUSE-IgnoreEnd