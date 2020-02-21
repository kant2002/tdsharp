using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Sets the parameters for TDLib initialization. Works only when the current authorization state is authorizationStateWaitTdlibParameters 
        /// </summary>
        public class SetTdlibParameters : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "setTdlibParameters";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Parameters
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("parameters")]
            public TdlibParameters Parameters { get; set; }
        }


        /// <summary>
        /// Sets the parameters for TDLib initialization. Works only when the current authorization state is authorizationStateWaitTdlibParameters 
        /// </summary>
        public static Task<Ok> SetTdlibParametersAsync(this Client client,
            TdlibParameters parameters = default(TdlibParameters))
        {
            return client.ExecuteAsync(new SetTdlibParameters
            {
                Parameters = parameters,
            });
        }
    }
}