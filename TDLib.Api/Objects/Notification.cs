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
        /// Contains information about a notification
        /// </summary>
        public partial class Notification : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "notification";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Unique persistent identifier of this notification
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("id")]
            public int Id { get; set; }

            /// <summary>
            /// Notification date
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("date")]
            public int Date { get; set; }

            /// <summary>
            /// True, if the notification was initially silent
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_silent")]
            public bool IsSilent { get; set; }

            /// <summary>
            /// Notification type
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("type")]
            public NotificationType Type { get; set; }
        }
    }
}