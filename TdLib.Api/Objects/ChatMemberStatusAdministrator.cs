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
        public partial class ChatMemberStatus : Object
        {
            /// <summary>
            /// The user is a member of the chat and has some additional privileges. In basic groups, administrators can edit and delete messages sent by others, add new members, ban unprivileged members, and manage video chats.
            /// In supergroups and channels, there are more detailed options for administrator privileges
            /// </summary>
            public class ChatMemberStatusAdministrator : ChatMemberStatus
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "chatMemberStatusAdministrator";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// A custom title of the administrator; 0-16 characters without emojis; applicable to supergroups only
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("custom_title")]
                public string CustomTitle { get; set; }

                /// <summary>
                /// True, if the current user can edit the administrator privileges for the called user
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("can_be_edited")]
                public bool CanBeEdited { get; set; }

                /// <summary>
                /// Rights of the administrator
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("rights")]
                public ChatAdministratorRights Rights { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd