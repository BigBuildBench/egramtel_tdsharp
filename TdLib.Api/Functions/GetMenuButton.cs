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
        /// Returns menu button set by the bot for the given user; for bots only
        /// </summary>
        public class GetMenuButton : Function<BotMenuButton>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getMenuButton";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Identifier of the user or 0 to get the default menu button
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("user_id")]
            public long UserId { get; set; }
        }

        /// <summary>
        /// Returns menu button set by the bot for the given user; for bots only
        /// </summary>
        public static Task<BotMenuButton> GetMenuButtonAsync(
            this Client client, long userId = default)
        {
            return client.ExecuteAsync(new GetMenuButton
            {
                UserId = userId
            });
        }
    }
}
// REUSE-IgnoreEnd