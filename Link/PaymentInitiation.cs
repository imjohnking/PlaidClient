using System.Text.Json.Serialization;

namespace Take5ive.Plaid.Link
{
    public class PaymentInitiation
    {
        [JsonPropertyName("payment_id")]
        public string PaymentId { get; set; }
    }
}
