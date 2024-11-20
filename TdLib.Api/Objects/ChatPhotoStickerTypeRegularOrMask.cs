using System;
using Newtonsoft.Json;

// REUSE-IgnoreStart
namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class ChatPhotoStickerType : Object
        {
            /// <summary>
            /// Describes type of sticker, which was used to create a chat photo
            /// </summary>
            public class ChatPhotoStickerTypeRegularOrMask : ChatPhotoStickerType
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "chatPhotoStickerTypeRegularOrMask";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Sticker set identifier
                /// </summary>
                [JsonConverter(typeof(Converter.Int64))]
                [JsonProperty("sticker_set_id")]
                public long StickerSetId { get; set; }

                /// <summary>
                /// Identifier of the sticker in the set
                /// </summary>
                [JsonConverter(typeof(Converter.Int64))]
                [JsonProperty("sticker_id")]
                public long StickerId { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd