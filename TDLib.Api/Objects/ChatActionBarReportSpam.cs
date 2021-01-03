using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class ChatActionBar : Object
        {
            /// <summary>
            /// Describes actions which should be possible to do through a chat action bar
            /// </summary>
            public class ChatActionBarReportSpam : ChatActionBar
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "chatActionBarReportSpam";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// If true, the chat was automatically archived and can be moved back to the main chat list using addChatToList simultaneously with setting chat notification settings to default using setChatNotificationSettings
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("can_unarchive")]
                public bool CanUnarchive { get; set; }
            }
        }
    }
}