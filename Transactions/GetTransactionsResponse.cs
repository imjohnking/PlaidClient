using System.Text.Json.Serialization;
using Take5ive.Plaid.Accounts;
using Take5ive.Plaid.Item;

namespace Take5ive.Plaid.Transactions
{
    public class GetTransactionsResponse : PlaidResponse
    {
        public Account[] Accounts { get; set; }

        public PlaidItem Item { get; set; }

        [JsonPropertyName("total_transactions")]
        public int TotalTransactions { get; set; }

        public Transaction[] Transactions { get; set; }
    }
}
