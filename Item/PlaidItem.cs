using System.Text.Json.Serialization;

namespace Take5ive.Plaid.Item
{
    public class PlaidItem
    {
        [JsonPropertyName("available_products")]
        public string[] AvailableProducts { get; set; }

        [JsonPropertyName("billed_products")]
        public string[] BilledProducts { get; set; }

        [JsonPropertyName("consent_expiration_time")]
        public object ConsentExpirationTime { get; set; }

        public object Error { get; set; }

        [JsonPropertyName("institution_id")]
        public string InstitutionID { get; set; }

        [JsonPropertyName("item_id")]
        public string ItemID { get; set; }

        public string Webhook { get; set; }
    }
}
