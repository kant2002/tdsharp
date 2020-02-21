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
        /// Represents a cell of a table 
        /// </summary>
        public class PageBlockTableCell : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "pageBlockTableCell";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Cell text; may be null. If the text is null, then the cell should be invisible 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("text")]
            public RichText Text { get; set; }

            /// <summary>
            /// True, if it is a header cell
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_header")]
            public bool IsHeader { get; set; }

            /// <summary>
            /// The number of columns the cell should span 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("colspan")]
            public int Colspan { get; set; }

            /// <summary>
            /// The number of rows the cell should span
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("rowspan")]
            public int Rowspan { get; set; }

            /// <summary>
            /// Horizontal cell content alignment 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("align")]
            public PageBlockHorizontalAlignment Align { get; set; }

            /// <summary>
            /// Vertical cell content alignment
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("valign")]
            public PageBlockVerticalAlignment Valign { get; set; }
        }
    }
}