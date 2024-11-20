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
        /// Returns forwards of a story as a message to public chats and reposts by public channels. Can be used only if the story is posted on behalf of the current user or story.can_get_statistics == true.
        /// For optimal performance, the number of returned messages and stories is chosen by TDLib
        /// </summary>
        public class GetStoryPublicForwards : Function<PublicForwards>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getStoryPublicForwards";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// The identifier of the sender of the story
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("story_sender_chat_id")]
            public long StorySenderChatId { get; set; }

            /// <summary>
            /// The identifier of the story
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("story_id")]
            public int StoryId { get; set; }

            /// <summary>
            /// Offset of the first entry to return as received from the previous request; use empty string to get the first chunk of results
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("offset")]
            public string Offset { get; set; }

            /// <summary>
            /// The maximum number of messages and stories to be returned; must be positive and can't be greater than 100. For optimal performance, the number of returned objects is chosen by TDLib and can be smaller than the specified limit
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("limit")]
            public int Limit { get; set; }
        }

        /// <summary>
        /// Returns forwards of a story as a message to public chats and reposts by public channels. Can be used only if the story is posted on behalf of the current user or story.can_get_statistics == true.
        /// For optimal performance, the number of returned messages and stories is chosen by TDLib
        /// </summary>
        public static Task<PublicForwards> GetStoryPublicForwardsAsync(
            this Client client, long storySenderChatId = default, int storyId = default, string offset = default, int limit = default)
        {
            return client.ExecuteAsync(new GetStoryPublicForwards
            {
                StorySenderChatId = storySenderChatId, StoryId = storyId, Offset = offset, Limit = limit
            });
        }
    }
}
// REUSE-IgnoreEnd