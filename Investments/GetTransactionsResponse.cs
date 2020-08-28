using System.Text.Json.Serialization;
using Take5ive.Plaid.Accounts;
using Take5ive.Plaid.Item;

namespace Take5ive.Plaid.Investments
{
    public class GetTransactionsResponse : PlaidResponse
    {
        public Account[] Accounts { get; set; }

        [JsonPropertyName("investment_transactions")]
        public InvestmentTransactions[] InvestmentTransactions { get; set; }

        public PlaidItem Item { get; set; }

        public Security[] Securities { get; set; }

        [JsonPropertyName("total_investment_transactions")]
        public int TotalInvestmentTransactions { get; set; }
    }
}
