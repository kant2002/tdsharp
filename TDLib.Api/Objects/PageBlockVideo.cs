using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class PageBlock : Object
        {
            /// <summary>
            /// A video
            /// </summary>
            public class PageBlockVideo : PageBlock
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "pageBlockVideo";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Video file; may be null
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("video")]
                public Video Video { get; set; }

                /// <summary>
                /// Video caption
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("caption")]
                public PageBlockCaption Caption { get; set; }

                /// <summary>
                /// True, if the video should be played automatically
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("need_autoplay")]
                public bool NeedAutoplay { get; set; }

                /// <summary>
                /// True, if the video should be looped
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_looped")]
                public bool IsLooped { get; set; }
            }
        }
    }
}