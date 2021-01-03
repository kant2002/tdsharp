using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class VectorPathCommand : Object
        {
            /// <summary>
            /// A cubic Bézier curve to a given point
            /// </summary>
            public class VectorPathCommandCubicBezierCurve : VectorPathCommand
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "vectorPathCommandCubicBezierCurve";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// The start control point of the curve
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("start_control_point")]
                public Point StartControlPoint { get; set; }

                /// <summary>
                /// The end control point of the curve
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("end_control_point")]
                public Point EndControlPoint { get; set; }

                /// <summary>
                /// The end point of the curve
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("end_point")]
                public Point EndPoint { get; set; }
            }
        }
    }
}