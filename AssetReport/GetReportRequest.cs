using System.Text.Json.Serialization;

namespace Take5ive.Plaid.AssetReport
{
    public class GetReportRequest : PlaidRequest
    {
        [JsonPropertyName("asset_report_token")]
        public string AssetReportToken { get; set; }

        [JsonPropertyName("include_insights")]
        public bool IncludeInsights { get; set; } = false;
    }
}
