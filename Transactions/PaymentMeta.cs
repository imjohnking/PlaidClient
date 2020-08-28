using System.Text.Json.Serialization;

namespace Take5ive.Plaid.Transactions
{
    public class PaymentMeta
    {
        [JsonPropertyName("by_order_of")]
        public object ByOrderOf { get; set; }

        public object Payee { get; set; }

        public object Payer { get; set; }

        [JsonPropertyName("payment_method")]
        public object PaymentMethod { get; set; }

        [JsonPropertyName("payment_processor")]
        public object PaymentProcessor { get; set; }

        [JsonPropertyName("ppd_id")]
        public object PPD_ID { get; set; }

        public object Reason { get; set; }

        [JsonPropertyName("reference_number")]
        public object ReferenceNumber { get; set; }
    }
}
