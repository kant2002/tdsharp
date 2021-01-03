using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class TextEntityType : Object
        {
            /// <summary>
            /// Text that must be formatted as if inside pre, and code HTML tags
            /// </summary>
            public class TextEntityTypePreCode : TextEntityType
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "textEntityTypePreCode";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Programming language of the code; as defined by the sender
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("language")]
                public string Language { get; set; }
            }
        }
    }
}