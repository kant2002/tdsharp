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
        /// The slow_mode_delay setting of a supergroup was changed 
        /// </summary>
        public partial class ChatEventAction : Object
        {
            /// <summary>
            /// The slow_mode_delay setting of a supergroup was changed 
            /// </summary>
            public class ChatEventSlowModeDelayChanged : ChatEventAction
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "chatEventSlowModeDelayChanged";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Previous value of slow_mode_delay 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("old_slow_mode_delay")]
                public int OldSlowModeDelay { get; set; }

                /// <summary>
                /// New value of slow_mode_delay
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("new_slow_mode_delay")]
                public int NewSlowModeDelay { get; set; }
            }
        }
    }
}