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
        /// Toggles whether sender signature is added to sent messages in a channel; requires can_change_info member right
        /// </summary>
        public class ToggleSupergroupSignMessages : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "toggleSupergroupSignMessages";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Identifier of the channel
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("supergroup_id")]
            public long SupergroupId { get; set; }

            /// <summary>
            /// New value of sign_messages
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("sign_messages")]
            public bool SignMessages { get; set; }
        }

        /// <summary>
        /// Toggles whether sender signature is added to sent messages in a channel; requires can_change_info member right
        /// </summary>
        public static Task<Ok> ToggleSupergroupSignMessagesAsync(
            this Client client, long supergroupId = default, bool signMessages = default)
        {
            return client.ExecuteAsync(new ToggleSupergroupSignMessages
            {
                SupergroupId = supergroupId, SignMessages = signMessages
            });
        }
    }
}
// REUSE-IgnoreEnd