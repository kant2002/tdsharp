using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class InlineKeyboardButtonType : Object
        {
            /// <summary>
            /// A button that forces an inline query to the bot to be inserted in the input field
            /// </summary>
            public class InlineKeyboardButtonTypeSwitchInline : InlineKeyboardButtonType
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "inlineKeyboardButtonTypeSwitchInline";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Inline query to be sent to the bot
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("query")]
                public string Query { get; set; }

                /// <summary>
                /// True, if the inline query should be sent from the current chat
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("in_current_chat")]
                public bool InCurrentChat { get; set; }
            }
        }
    }
}