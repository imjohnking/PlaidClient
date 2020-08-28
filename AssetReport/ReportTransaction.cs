using System.Text.Json.Serialization;

namespace Take5ive.Plaid.AssetReport
{
    public class ReportTransaction
    {
        [JsonPropertyName("account_id")]
        public string AccountID { get; set; }

        public float Amount { get; set; }

        public string Date { get; set; }

        [JsonPropertyName("iso_currency_code")]
        public string ISOCurrencyCode { get; set; }

        [JsonPropertyName("original_description")]
        public string OriginalDescription { get; set; }

        public bool Pending { get; set; }

        [JsonPropertyName("transaction_id")]
        public string TransactionID { get; set; }

        [JsonPropertyName("unofficial_currency_code")]
        public object UnofficialCurrencyCode { get; set; }
    }
}
