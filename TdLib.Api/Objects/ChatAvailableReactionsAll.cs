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
        public partial class ChatAvailableReactions : Object
        {
            /// <summary>
            /// Describes reactions available in the chat
            /// </summary>
            public class ChatAvailableReactionsAll : ChatAvailableReactions
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "chatAvailableReactionsAll";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// The maximum allowed number of reactions per message; 1-11
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("max_reaction_count")]
                public int MaxReactionCount { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd