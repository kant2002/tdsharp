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
        /// Contains information about a proxy server
        /// </summary>
        public partial class Proxy : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "proxy";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Unique identifier of the proxy
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("id")]
            public int Id { get; set; }

            /// <summary>
            /// Proxy server IP address
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("server")]
            public string Server { get; set; }

            /// <summary>
            /// Proxy server port
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("port")]
            public int Port { get; set; }

            /// <summary>
            /// Point in time (Unix timestamp) when the proxy was last used; 0 if never
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("last_used_date")]
            public int LastUsedDate { get; set; }

            /// <summary>
            /// True, if the proxy is enabled now
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_enabled")]
            public bool IsEnabled { get; set; }

            /// <summary>
            /// Type of the proxy
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("type")]
            public ProxyType Type { get; set; }
        }
    }
}