using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class AuthenticationCodeType : Object
        {
            /// <summary>
            /// An authentication code is delivered via an SMS message to the specified phone number
            /// </summary>
            public class AuthenticationCodeTypeSms : AuthenticationCodeType
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "authenticationCodeTypeSms";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Length of the code
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("length")]
                public int Length { get; set; }
            }
        }
    }
}