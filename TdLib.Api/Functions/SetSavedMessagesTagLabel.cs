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
        /// Changes label of a Saved Messages tag; for Telegram Premium users only
        /// </summary>
        public class SetSavedMessagesTagLabel : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "setSavedMessagesTagLabel";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// The tag which label will be changed
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("tag")]
            public ReactionType Tag { get; set; }

            /// <summary>
            /// New label for the tag; 0-12 characters
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("label")]
            public string Label { get; set; }
        }

        /// <summary>
        /// Changes label of a Saved Messages tag; for Telegram Premium users only
        /// </summary>
        public static Task<Ok> SetSavedMessagesTagLabelAsync(
            this Client client, ReactionType tag = default, string label = default)
        {
            return client.ExecuteAsync(new SetSavedMessagesTagLabel
            {
                Tag = tag, Label = label
            });
        }
    }
}
// REUSE-IgnoreEnd