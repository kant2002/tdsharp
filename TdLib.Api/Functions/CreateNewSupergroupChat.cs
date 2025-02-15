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
        /// Creates a new supergroup or channel and sends a corresponding messageSupergroupChatCreate. Returns the newly created chat
        /// </summary>
        public class CreateNewSupergroupChat : Function<Chat>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "createNewSupergroupChat";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Title of the new chat; 1-128 characters
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("title")]
            public string Title { get; set; }

            /// <summary>
            /// True, if a channel chat needs to be created
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_channel")]
            public bool IsChannel { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("description")]
            public string Description { get; set; }

            /// <summary>
            /// Chat location if a location-based supergroup is being created; pass null to create an ordinary supergroup chat
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("location")]
            public ChatLocation Location { get; set; }

            /// <summary>
            /// True, if the supergroup is created for importing messages using importMessage
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("for_import")]
            public bool ForImport { get; set; }
        }

        /// <summary>
        /// Creates a new supergroup or channel and sends a corresponding messageSupergroupChatCreate. Returns the newly created chat
        /// </summary>
        public static Task<Chat> CreateNewSupergroupChatAsync(
            this Client client, string title = default, bool isChannel = default, string description = default, ChatLocation location = default, bool forImport = default)
        {
            return client.ExecuteAsync(new CreateNewSupergroupChat
            {
                Title = title, IsChannel = isChannel, Description = description, Location = location, ForImport = forImport
            });
        }
    }
}