using System.Text.Json.Serialization;

namespace Take5ive.Plaid.Investments
{
    public class Holding
    {
        [JsonPropertyName("account_id")]
        public string AccountID { get; set; }

        [JsonPropertyName("cost_basis")]
        public float CostBasis { get; set; }

        [JsonPropertyName("institution_price")]
        public float InstitutionPrice { get; set; }

        [JsonPropertyName("institution_price_as_of")]
        public object InstitutionPriceAsOf { get; set; }

        [JsonPropertyName("institution_value")]
        public float InstitutionValue { get; set; }

        [JsonPropertyName("iso_currency_code")]
        public string ISOCurrencyCode { get; set; }

        public float Quantity { get; set; }
        
        [JsonPropertyName("security_id")]
        public string SecurityID { get; set; }

        [JsonPropertyName("unofficial_currency_code")]
        public object UnofficialCurrencyCode { get; set; }
    }
}
