using System.Text.Json.Serialization;

namespace Take5ive.Plaid.AssetReport
{
    public class CreateReportResponse : PlaidResponse
    {
        [JsonPropertyName("asset_report_id")]
        public string AssetReportID { get; set; }

        [JsonPropertyName("asset_report_token")]
        public string AssetReportToken { get; set; }
    }
}
