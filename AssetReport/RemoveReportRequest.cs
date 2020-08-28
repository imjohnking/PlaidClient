using System.Text.Json.Serialization;

namespace Take5ive.Plaid.AssetReport
{
    public class RemoveReportRequest : PlaidRequest
    {
        [JsonPropertyName("asset_report_token")]
        public string AssetReportToken { get; set; }
    }
}
