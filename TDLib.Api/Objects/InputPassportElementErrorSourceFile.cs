using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class InputPassportElementErrorSource : Object
        {
            /// <summary>
            /// The file contains an error. The error is considered resolved when the file changes
            /// </summary>
            public class InputPassportElementErrorSourceFile : InputPassportElementErrorSource
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "inputPassportElementErrorSourceFile";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Current hash of the file which has the error
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("file_hash")]
                public byte[] FileHash { get; set; }
            }
        }
    }
}