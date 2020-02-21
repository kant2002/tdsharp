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
        /// Contains a TDLib internal log verbosity level 
        /// </summary>
        public class LogVerbosityLevel : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "logVerbosityLevel";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Log verbosity level
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("verbosity_level")]
            public int VerbosityLevel { get; set; }
        }
    }
}