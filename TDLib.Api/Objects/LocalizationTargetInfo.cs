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
        /// Contains information about the current localization target
        /// </summary>
        public partial class LocalizationTargetInfo : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "localizationTargetInfo";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// List of available language packs for this application
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("language_packs")]
            public LanguagePackInfo[] LanguagePacks { get; set; }
        }
    }
}