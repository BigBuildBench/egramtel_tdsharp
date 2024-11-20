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
        /// Returns a confirmation text to be shown to the user before starting message import
        /// </summary>
        public class GetMessageImportConfirmationText : Function<Text>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getMessageImportConfirmationText";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Identifier of a chat to which the messages will be imported. It must be an identifier of a private chat with a mutual contact or an identifier of a supergroup chat with can_change_info member right
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_id")]
            public long ChatId { get; set; }
        }

        /// <summary>
        /// Returns a confirmation text to be shown to the user before starting message import
        /// </summary>
        public static Task<Text> GetMessageImportConfirmationTextAsync(
            this Client client, long chatId = default)
        {
            return client.ExecuteAsync(new GetMessageImportConfirmationText
            {
                ChatId = chatId
            });
        }
    }
}
// REUSE-IgnoreEnd