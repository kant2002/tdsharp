using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class InputPassportElement : Object
        {
            /// <summary>
            /// A Telegram Passport element to be saved containing the user's temporary registration
            /// </summary>
            public class InputPassportElementTemporaryRegistration : InputPassportElement
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "inputPassportElementTemporaryRegistration";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// The temporary registration document to be saved
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("temporary_registration")]
                public InputPersonalDocument TemporaryRegistration { get; set; }
            }
        }
    }
}