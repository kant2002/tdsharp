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
            /// Point in time (Unix timestamp) when the payment was made
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("date")]
            public int Date { get; set; }

            /// <summary>
            /// User identifier of the payment provider bot
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("payments_provider_user_id")]
            public int PaymentsProviderUserId { get; set; }

            /// <summary>
            /// Contains information about the invoice
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("invoice")]
            public Invoice Invoice { get; set; }

            /// <summary>
            /// Contains order information; may be null
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
            /// Title of the saved credentials
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("credentials_title")]
            public string CredentialsTitle { get; set; }
        }
    }
}