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
        /// The chat is public, because it is a location-based supergroup
        /// </summary>
        public partial class PublicChatType : Object
        {
            /// <summary>
            /// The chat is public, because it is a location-based supergroup
            /// </summary>
            public class PublicChatTypeIsLocationBased : PublicChatType
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "publicChatTypeIsLocationBased";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }
            }
        }
    }
}