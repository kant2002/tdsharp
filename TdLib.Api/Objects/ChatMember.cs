using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Describes a user or a chat as a member of another chat
        /// </summary>
        public partial class ChatMember : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "chatMember";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Identifier of the chat member. Currently, other chats can be only Left or Banned. Only supergroups and channels can have other chats as Left or Banned members and these chats must be supergroups or channels
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("member_id")]
            public MessageSender MemberId { get; set; }

            /// <summary>
            /// Identifier of a user that invited/promoted/banned this member in the chat; 0 if unknown
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("inviter_user_id")]
            public long InviterUserId { get; set; }

            /// <summary>
            /// Point in time (Unix timestamp) when the user joined the chat
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("joined_chat_date")]
            public int JoinedChatDate { get; set; }

            /// <summary>
            /// Status of the member in the chat
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("status")]
            public ChatMemberStatus Status { get; set; }
        }
    }
}