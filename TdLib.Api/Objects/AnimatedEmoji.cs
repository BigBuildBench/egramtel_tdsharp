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
        /// <summary>
        /// Describes an animated or custom representation of an emoji
        /// </summary>
        public partial class AnimatedEmoji : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "animatedEmoji";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Sticker for the emoji; may be null if yet unknown for a custom emoji. If the sticker is a custom emoji, then it can have arbitrary format
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("sticker")]
            public Sticker Sticker { get; set; }

            /// <summary>
            /// Expected width of the sticker, which can be used if the sticker is null
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("sticker_width")]
            public int StickerWidth { get; set; }

            /// <summary>
            /// Expected height of the sticker, which can be used if the sticker is null
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("sticker_height")]
            public int StickerHeight { get; set; }

            /// <summary>
            /// Emoji modifier fitzpatrick type; 0-6; 0 if none
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("fitzpatrick_type")]
            public int FitzpatrickType { get; set; }

            /// <summary>
            /// File containing the sound to be played when the sticker is clicked; may be null. The sound is encoded with the Opus codec, and stored inside an OGG container
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("sound")]
            public File Sound { get; set; }
        }
    }
}
// REUSE-IgnoreEnd