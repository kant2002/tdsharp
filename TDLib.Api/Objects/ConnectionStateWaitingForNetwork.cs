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
        /// Currently waiting for the network to become available. Use setNetworkType to change the available network type
        /// </summary>
        public partial class ConnectionState : Object
        {
            /// <summary>
            /// Currently waiting for the network to become available. Use setNetworkType to change the available network type
            /// </summary>
            public class ConnectionStateWaitingForNetwork : ConnectionState
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "connectionStateWaitingForNetwork";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }
            }
        }
    }
}