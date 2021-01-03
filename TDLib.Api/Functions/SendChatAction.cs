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
        /// Sends a notification about user activity in a chat
        /// </summary>
        public class SendChatAction : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "sendChatAction";

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
            /// If not 0, a message thread identifier in which the action was performed
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("message_thread_id")]
            public long MessageThreadId { get; set; }

            /// <summary>
            /// The action description
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("action")]
            public ChatAction Action { get; set; }
        }

        /// <summary>
        /// Sends a notification about user activity in a chat
        /// </summary>
        public static Task<Ok> SendChatActionAsync(
            this Client client, long chatId = default, long messageThreadId = default, ChatAction action = default)
        {
            return client.ExecuteAsync(new SendChatAction
            {
                ChatId = chatId, MessageThreadId = messageThreadId, Action = action
            });
        }
    }
}