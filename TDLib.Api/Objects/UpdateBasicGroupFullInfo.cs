using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class Update : Object
        {
            /// <summary>
            /// Some data from basicGroupFullInfo has been changed
            /// </summary>
            public class UpdateBasicGroupFullInfo : Update
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "updateBasicGroupFullInfo";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Identifier of a basic group
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("basic_group_id")]
                public int BasicGroupId { get; set; }

                /// <summary>
                /// New full information about the group
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("basic_group_full_info")]
                public BasicGroupFullInfo BasicGroupFullInfo { get; set; }
            }
        }
    }
}