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
        /// Edits the caption of an inline message sent via a bot; for bots only 
        /// </summary>
        public class EditInlineMessageCaption : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "editInlineMessageCaption";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Inline message identifier 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("inline_message_id")]
            public string InlineMessageId { get; set; }

            /// <summary>
            /// The new message reply markup 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("reply_markup")]
            public ReplyMarkup ReplyMarkup { get; set; }

            /// <summary>
            /// New message content caption; 0-GetOption("message_caption_length_max") characters
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("caption")]
            public FormattedText Caption { get; set; }
        }


        /// <summary>
        /// Edits the caption of an inline message sent via a bot; for bots only 
        /// </summary>
        public static Task<Ok> EditInlineMessageCaptionAsync(this Client client,
            string inlineMessageId = default(string),
            ReplyMarkup replyMarkup = default(ReplyMarkup),
            FormattedText caption = default(FormattedText))
        {
            return client.ExecuteAsync(new EditInlineMessageCaption
            {
                InlineMessageId = inlineMessageId,
                ReplyMarkup = replyMarkup,
                Caption = caption,
            });
        }
    }
}