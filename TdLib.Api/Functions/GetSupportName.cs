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
        /// Returns localized name of the Telegram support user; for Telegram support only
        /// </summary>
        public class GetSupportName : Function<Text>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getSupportName";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }


        }

        /// <summary>
        /// Returns localized name of the Telegram support user; for Telegram support only
        /// </summary>
        public static Task<Text> GetSupportNameAsync(
            this Client client)
        {
            return client.ExecuteAsync(new GetSupportName
            {
                
            });
        }
    }
}
// REUSE-IgnoreEnd