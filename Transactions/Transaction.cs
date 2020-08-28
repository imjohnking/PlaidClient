using System.Text.Json.Serialization;

namespace Take5ive.Plaid.Transactions
{
    public class Transaction
    {
        [JsonPropertyName("account_id")]
        public string AccountID { get; set; }

        [JsonPropertyName("account_owner")]
        public object AccountOwner { get; set; }

        public float Amount { get; set; }

        [JsonPropertyName("authorized_date")]
        public object AuthorizedDate { get; set; }

        public string[] Category { get; set; }

        [JsonPropertyName("category_id")]
        public string CategoryID { get; set; }

        public string Date { get; set; }

        [JsonPropertyName("iso_currency_code")]
        public string ISOCurrencyCode { get; set; }

        public Location Location { get; set; }

        [JsonPropertyName("merchant_name")]
        public string MerchantName { get; set; }

        public string Name { get; set; }

        [JsonPropertyName("payment_channel")]
        public string PaymentChannel { get; set; }

        [JsonPropertyName("payment_meta")]
        public PaymentMeta PaymentMeta { get; set; }

        public bool Pending { get; set; }

        [JsonPropertyName("pending_transaction_id")]
        public object PendingTransactionID { get; set; }

        [JsonPropertyName("transaction_code")]
        public object TransactionCode { get; set; }

        [JsonPropertyName("transaction_id")]
        public string TransactionID { get; set; }

        [JsonPropertyName("transaction_type")]
        public string TransactionType { get; set; }

        [JsonPropertyName("unofficial_currency_code")]
        public object UnofficialCurrencyCode { get; set; }
    }
}
