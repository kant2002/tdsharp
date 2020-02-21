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
        /// A video note message 
        /// </summary>
        public partial class InputMessageContent : Object
        {
            /// <summary>
            /// A video note message 
            /// </summary>
            public class InputMessageVideoNote : InputMessageContent
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "inputMessageVideoNote";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Video note to be sent 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("video_note")]
                public InputFile VideoNote { get; set; }

                /// <summary>
                /// Video thumbnail, if available 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("thumbnail")]
                public InputThumbnail Thumbnail { get; set; }

                /// <summary>
                /// Duration of the video, in seconds 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("duration")]
                public int Duration { get; set; }

                /// <summary>
                /// Video width and height; must be positive and not greater than 640
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("length")]
                public int Length { get; set; }
            }
        }
    }
}