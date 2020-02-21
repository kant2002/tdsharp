using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Changes the discussion group of a channel chat; requires can_change_info rights in the channel if it is specified 
        /// </summary>
        public class SetChatDiscussionGroup : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "setChatDiscussionGroup";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Identifier of the channel chat. Pass 0 to remove a link from the supergroup passed in the second argument to a linked channel chat (requires can_pin_messages rights in the supergroup) 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_id")]
            public long ChatId { get; set; }

            /// <summary>
            /// Identifier of a new channel's discussion group. Use 0 to remove the discussion group.
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("discussion_chat_id")]
            public long DiscussionChatId { get; set; }
        }


        /// <summary>
        /// Changes the discussion group of a channel chat; requires can_change_info rights in the channel if it is specified 
        /// </summary>
        public static Task<Ok> SetChatDiscussionGroupAsync(this Client client,
            long chatId = default(long),
            long discussionChatId = default(long))
        {
            return client.ExecuteAsync(new SetChatDiscussionGroup
            {
                ChatId = chatId,
                DiscussionChatId = discussionChatId,
            });
        }
    }
}