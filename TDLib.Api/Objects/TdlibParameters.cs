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
        /// Contains parameters for TDLib initialization
        /// </summary>
        public partial class TdlibParameters : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "tdlibParameters";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// If set to true, the Telegram test environment will be used instead of the production environment
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("use_test_dc")]
            public bool UseTestDc { get; set; }

            /// <summary>
            /// The path to the directory for the persistent database; if empty, the current working directory will be used
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("database_directory")]
            public string DatabaseDirectory { get; set; }

            /// <summary>
            /// The path to the directory for storing files; if empty, database_directory will be used
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("files_directory")]
            public string FilesDirectory { get; set; }

            /// <summary>
            /// If set to true, information about downloaded and uploaded files will be saved between application restarts
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("use_file_database")]
            public bool UseFileDatabase { get; set; }

            /// <summary>
            /// If set to true, the library will maintain a cache of users, basic groups, supergroups, channels and secret chats. Implies use_file_database
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("use_chat_info_database")]
            public bool UseChatInfoDatabase { get; set; }

            /// <summary>
            /// If set to true, the library will maintain a cache of chats and messages. Implies use_chat_info_database
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("use_message_database")]
            public bool UseMessageDatabase { get; set; }

            /// <summary>
            /// If set to true, support for secret chats will be enabled
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("use_secret_chats")]
            public bool UseSecretChats { get; set; }

            /// <summary>
            /// Application identifier for Telegram API access, which can be obtained at https://my.telegram.org
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("api_id")]
            public int ApiId { get; set; }

            /// <summary>
            /// Application identifier hash for Telegram API access, which can be obtained at https://my.telegram.org
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("api_hash")]
            public string ApiHash { get; set; }

            /// <summary>
            /// IETF language tag of the user's operating system language; must be non-empty
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("system_language_code")]
            public string SystemLanguageCode { get; set; }

            /// <summary>
            /// Model of the device the application is being run on; must be non-empty
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("device_model")]
            public string DeviceModel { get; set; }

            /// <summary>
            /// Version of the operating system the application is being run on. If empty, the version is automatically detected by TDLib
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("system_version")]
            public string SystemVersion { get; set; }

            /// <summary>
            /// Application version; must be non-empty
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("application_version")]
            public string ApplicationVersion { get; set; }

            /// <summary>
            /// If set to true, old files will automatically be deleted
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("enable_storage_optimizer")]
            public bool EnableStorageOptimizer { get; set; }

            /// <summary>
            /// If set to true, original file names will be ignored. Otherwise, downloaded files will be saved under names as close as possible to the original name
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("ignore_file_names")]
            public bool IgnoreFileNames { get; set; }
        }
    }
}