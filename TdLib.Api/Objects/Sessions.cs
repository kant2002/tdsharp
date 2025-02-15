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
        /// Contains a list of sessions
        /// </summary>
        public partial class Sessions : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "sessions";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// List of sessions
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("sessions")]
            public Session[] Sessions_ { get; set; }

            /// <summary>
            /// Number of days of inactivity before sessions will automatically be terminated; 1-366 days
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("inactive_session_ttl_days")]
            public int InactiveSessionTtlDays { get; set; }
        }
    }
}