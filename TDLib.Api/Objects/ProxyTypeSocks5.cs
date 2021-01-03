using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class ProxyType : Object
        {
            /// <summary>
            /// Describes the type of a proxy server
            /// </summary>
            public class ProxyTypeSocks5 : ProxyType
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "proxyTypeSocks5";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Username for logging in; may be empty
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("username")]
                public string Username { get; set; }

                /// <summary>
                /// Password for logging in; may be empty
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("password")]
                public string Password { get; set; }
            }
        }
    }
}