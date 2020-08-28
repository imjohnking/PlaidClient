using System.Text.Json.Serialization;

namespace Take5ive.Plaid.AssetReport
{
    public class HistoricalBalances
    {
        public float Current { get; set; }

        public string Date { get; set; }

        [JsonPropertyName("iso_currency_code")]
        public string ISOCurrencyCode { get; set; }

        [JsonPropertyName("unofficial_currency_code")]
        public object UnofficialCurrencyCode { get; set; }
    }
}
