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
        /// Reports messages in a supergroup as spam; requires administrator rights in the supergroup
        /// </summary>
        public class ReportSupergroupSpam : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "reportSupergroupSpam";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Supergroup identifier
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("supergroup_id")]
            public long SupergroupId { get; set; }

            /// <summary>
            /// Identifiers of messages to report
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("message_ids")]
            public long[] MessageIds { get; set; }
        }

        /// <summary>
        /// Reports messages in a supergroup as spam; requires administrator rights in the supergroup
        /// </summary>
        public static Task<Ok> ReportSupergroupSpamAsync(
            this Client client, long supergroupId = default, long[] messageIds = default)
        {
            return client.ExecuteAsync(new ReportSupergroupSpam
            {
                SupergroupId = supergroupId, MessageIds = messageIds
            });
        }
    }
}