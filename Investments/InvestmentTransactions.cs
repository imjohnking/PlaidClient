using System.Text.Json.Serialization;

namespace Take5ive.Plaid.Investments
{
    public class InvestmentTransactions
    {
        [JsonPropertyName("investment_transaction_id")]
        public string InvestmentTransactionID { get; set; }

        [JsonPropertyName("account_id")]
        public string AccountID { get; set; }

        [JsonPropertyName("security_id")]
        public string SecurityID { get; set; }

        [JsonPropertyName("cancel_transaction_id")]
        public string CancelTransactionID { get; set; }

        public string Date { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public float Amount { get; set; }

        public float Price { get; set; }

        public float Fees { get; set; }

        public string Type { get; set; }

        [JsonPropertyName("iso_currency_code")]
        public string ISOCurrencyCode { get; set; }

        [JsonPropertyName("unofficial_currency_code")]
        public object UnofficialCurrencyCode { get; set; }
    }
}
