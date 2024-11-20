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
        /// Contains information about a successful payment
        /// </summary>
        public partial class PaymentReceipt : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "paymentReceipt";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Product title
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("title")]
            public string Title { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("description")]
            public FormattedText Description { get; set; }

            /// <summary>
            /// Product photo; may be null
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("photo")]
            public Photo Photo { get; set; }

            /// <summary>
            /// Point in time (Unix timestamp) when the payment was made
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("date")]
            public int Date { get; set; }

            /// <summary>
            /// User identifier of the seller bot
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("seller_bot_user_id")]
            public long SellerBotUserId { get; set; }

            /// <summary>
            /// User identifier of the payment provider bot
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("payment_provider_user_id")]
            public long PaymentProviderUserId { get; set; }

            /// <summary>
            /// Information about the invoice
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("invoice")]
            public Invoice Invoice { get; set; }

            /// <summary>
            /// Order information; may be null
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("order_info")]
            public OrderInfo OrderInfo { get; set; }

            /// <summary>
            /// Chosen shipping option; may be null
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("shipping_option")]
            public ShippingOption ShippingOption { get; set; }

            /// <summary>
            /// Title of the saved credentials chosen by the buyer
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("credentials_title")]
            public string CredentialsTitle { get; set; }

            /// <summary>
            /// The amount of tip chosen by the buyer in the smallest units of the currency
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("tip_amount")]
            public long TipAmount { get; set; }
        }
    }
}
// REUSE-IgnoreEnd