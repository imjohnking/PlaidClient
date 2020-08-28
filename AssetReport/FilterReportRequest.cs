using System.Text.Json.Serialization;

namespace Take5ive.Plaid.AssetReport
{
    public class FilterReportRequest : PlaidRequest
    {
        [JsonPropertyName("asset_report_token")]
        public string AssetReportToken { get; set; }

        [JsonPropertyName("account_ids_to_exclude")]
        public string[] AccountIDsToExclude { get; set; }
    }
}
