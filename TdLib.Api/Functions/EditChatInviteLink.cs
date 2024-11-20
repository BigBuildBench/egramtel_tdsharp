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
        /// Edits a non-primary invite link for a chat. Available for basic groups, supergroups, and channels. Requires administrator privileges and can_invite_users right in the chat for own links and owner privileges for other links
        /// </summary>
        public class EditChatInviteLink : Function<ChatInviteLink>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "editChatInviteLink";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Chat identifier
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_id")]
            public long ChatId { get; set; }

            /// <summary>
            /// Invite link to be edited
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("invite_link")]
            public string InviteLink { get; set; }

            /// <summary>
            /// Invite link name; 0-32 characters
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("name")]
            public string Name { get; set; }

            /// <summary>
            /// Point in time (Unix timestamp) when the link will expire; pass 0 if never
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("expiration_date")]
            public int ExpirationDate { get; set; }

            /// <summary>
            /// The maximum number of chat members that can join the chat via the link simultaneously; 0-99999; pass 0 if not limited
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("member_limit")]
            public int MemberLimit { get; set; }

            /// <summary>
            /// Pass true if users joining the chat via the link need to be approved by chat administrators. In this case, member_limit must be 0
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("creates_join_request")]
            public bool CreatesJoinRequest { get; set; }
        }

        /// <summary>
        /// Edits a non-primary invite link for a chat. Available for basic groups, supergroups, and channels. Requires administrator privileges and can_invite_users right in the chat for own links and owner privileges for other links
        /// </summary>
        public static Task<ChatInviteLink> EditChatInviteLinkAsync(
            this Client client, long chatId = default, string inviteLink = default, string name = default, int expirationDate = default, int memberLimit = default, bool createsJoinRequest = default)
        {
            return client.ExecuteAsync(new EditChatInviteLink
            {
                ChatId = chatId, InviteLink = inviteLink, Name = name, ExpirationDate = expirationDate, MemberLimit = memberLimit, CreatesJoinRequest = createsJoinRequest
            });
        }
    }
}
// REUSE-IgnoreEnd