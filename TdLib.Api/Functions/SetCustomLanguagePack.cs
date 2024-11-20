using System;
using System.Threading.Tasks;
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
        /// Adds or changes a custom local language pack to the current localization target
        /// </summary>
        public class SetCustomLanguagePack : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "setCustomLanguagePack";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Information about the language pack. Language pack identifier must start with 'X', consist only of English letters, digits and hyphens, and must not exceed 64 characters. Can be called before authorization
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("info")]
            public LanguagePackInfo Info { get; set; }

            /// <summary>
            /// Strings of the new language pack
            /// </summary>
            [JsonProperty("strings", ItemConverterType = typeof(Converter))]
            public LanguagePackString[] Strings { get; set; }
        }

        /// <summary>
        /// Adds or changes a custom local language pack to the current localization target
        /// </summary>
        public static Task<Ok> SetCustomLanguagePackAsync(
            this Client client, LanguagePackInfo info = default, LanguagePackString[] strings = default)
        {
            return client.ExecuteAsync(new SetCustomLanguagePack
            {
                Info = info, Strings = strings
            });
        }
    }
}
// REUSE-IgnoreEnd