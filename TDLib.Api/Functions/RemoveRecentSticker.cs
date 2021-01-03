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
        /// Removes a sticker from the list of recently used stickers
        /// </summary>
        public class RemoveRecentSticker : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "removeRecentSticker";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Pass true to remove the sticker from the list of stickers recently attached to photo or video files; pass false to remove the sticker from the list of recently sent stickers
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_attached")]
            public bool IsAttached { get; set; }

            /// <summary>
            /// Sticker file to delete
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("sticker")]
            public InputFile Sticker { get; set; }
        }

        /// <summary>
        /// Removes a sticker from the list of recently used stickers
        /// </summary>
        public static Task<Ok> RemoveRecentStickerAsync(
            this Client client, bool isAttached = default, InputFile sticker = default)
        {
            return client.ExecuteAsync(new RemoveRecentSticker
            {
                IsAttached = isAttached, Sticker = sticker
            });
        }
    }
}