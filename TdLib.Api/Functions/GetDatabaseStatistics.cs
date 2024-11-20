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
        /// Returns database statistics
        /// </summary>
        public class GetDatabaseStatistics : Function<DatabaseStatistics>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getDatabaseStatistics";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }


        }

        /// <summary>
        /// Returns database statistics
        /// </summary>
        public static Task<DatabaseStatistics> GetDatabaseStatisticsAsync(
            this Client client)
        {
            return client.ExecuteAsync(new GetDatabaseStatistics
            {
                
            });
        }
    }
}
// REUSE-IgnoreEnd