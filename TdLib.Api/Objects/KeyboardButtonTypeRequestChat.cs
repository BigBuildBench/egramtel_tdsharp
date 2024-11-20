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
        public partial class KeyboardButtonType : Object
        {
            /// <summary>
            /// A button that requests a chat to be shared by the current user; available only in private chats. Use the method shareChatWithBot to complete the request
            /// </summary>
            public class KeyboardButtonTypeRequestChat : KeyboardButtonType
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "keyboardButtonTypeRequestChat";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Unique button identifier
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("id")]
                public int Id { get; set; }

                /// <summary>
                /// True, if the chat must be a channel; otherwise, a basic group or a supergroup chat is shared
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("chat_is_channel")]
                public bool ChatIsChannel { get; set; }

                /// <summary>
                /// True, if the chat must or must not be a forum supergroup
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("restrict_chat_is_forum")]
                public bool RestrictChatIsForum { get; set; }

                /// <summary>
                /// True, if the chat must be a forum supergroup; otherwise, the chat must not be a forum supergroup. Ignored if restrict_chat_is_forum is false
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("chat_is_forum")]
                public bool ChatIsForum { get; set; }

                /// <summary>
                /// True, if the chat must or must not have a username
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("restrict_chat_has_username")]
                public bool RestrictChatHasUsername { get; set; }

                /// <summary>
                /// True, if the chat must have a username; otherwise, the chat must not have a username. Ignored if restrict_chat_has_username is false
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("chat_has_username")]
                public bool ChatHasUsername { get; set; }

                /// <summary>
                /// True, if the chat must be created by the current user
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("chat_is_created")]
                public bool ChatIsCreated { get; set; }

                /// <summary>
                /// Expected user administrator rights in the chat; may be null if they aren't restricted
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("user_administrator_rights")]
                public ChatAdministratorRights UserAdministratorRights { get; set; }

                /// <summary>
                /// Expected bot administrator rights in the chat; may be null if they aren't restricted
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("bot_administrator_rights")]
                public ChatAdministratorRights BotAdministratorRights { get; set; }

                /// <summary>
                /// True, if the bot must be a member of the chat; for basic group and supergroup chats only
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("bot_is_member")]
                public bool BotIsMember { get; set; }

                /// <summary>
                /// Pass true to request title of the chat; bots only
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("request_title")]
                public bool RequestTitle { get; set; }

                /// <summary>
                /// Pass true to request username of the chat; bots only
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("request_username")]
                public bool RequestUsername { get; set; }

                /// <summary>
                /// Pass true to request photo of the chat; bots only
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("request_photo")]
                public bool RequestPhoto { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd