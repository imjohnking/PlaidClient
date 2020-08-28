using System.Text.Json.Serialization;
using Take5ive.Plaid.Accounts;

namespace Take5ive.Plaid.AssetReport
{
    public class ReportAccount : Account
    {
        [JsonPropertyName("days_available")]
        public int DaysAvailable { get; set; }

        [JsonPropertyName("historical_balances")]
        public HistoricalBalances[] HistoricalBalances { get; set; }

        [JsonPropertyName("ownership_type")]
        public object OwnershipType { get; set; }

        public ReportTransaction[] Transactions { get; set; }

    }
}
