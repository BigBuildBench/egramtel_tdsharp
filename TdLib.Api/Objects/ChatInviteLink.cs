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
        /// <summary>
        /// Contains a chat invite link
        /// </summary>
        public partial class ChatInviteLink : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "chatInviteLink";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Chat invite link
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("invite_link")]
            public string InviteLink { get; set; }

            /// <summary>
            /// Name of the link
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("name")]
            public string Name { get; set; }

            /// <summary>
            /// User identifier of an administrator created the link
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("creator_user_id")]
            public long CreatorUserId { get; set; }

            /// <summary>
            /// Point in time (Unix timestamp) when the link was created
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("date")]
            public int Date { get; set; }

            /// <summary>
            /// Point in time (Unix timestamp) when the link was last edited; 0 if never or unknown
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("edit_date")]
            public int EditDate { get; set; }

            /// <summary>
            /// Point in time (Unix timestamp) when the link will expire; 0 if never
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("expiration_date")]
            public int ExpirationDate { get; set; }

            /// <summary>
            /// The maximum number of members, which can join the chat using the link simultaneously; 0 if not limited. Always 0 if the link requires approval
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("member_limit")]
            public int MemberLimit { get; set; }

            /// <summary>
            /// Number of chat members, which joined the chat using the link
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("member_count")]
            public int MemberCount { get; set; }

            /// <summary>
            /// Number of pending join requests created using this link
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("pending_join_request_count")]
            public int PendingJoinRequestCount { get; set; }

            /// <summary>
            /// True, if the link only creates join request. If true, total number of joining members will be unlimited
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("creates_join_request")]
            public bool CreatesJoinRequest { get; set; }

            /// <summary>
            /// True, if the link is primary. Primary invite link can't have name, expiration date, or usage limit. There is exactly one primary invite link for each administrator with can_invite_users right at a given time
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_primary")]
            public bool IsPrimary { get; set; }

            /// <summary>
            /// True, if the link was revoked
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_revoked")]
            public bool IsRevoked { get; set; }
        }
    }
}
// REUSE-IgnoreEnd