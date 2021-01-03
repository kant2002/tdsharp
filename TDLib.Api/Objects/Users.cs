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
        /// Represents a list of users
        /// </summary>
        public partial class Users : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "users";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Approximate total count of users found
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("total_count")]
            public int TotalCount { get; set; }

            /// <summary>
            /// A list of user identifiers
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("user_ids")]
            public int[] UserIds { get; set; }
        }
    }
}