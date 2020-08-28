using System.Text.Json.Serialization;

namespace Take5ive.Plaid.AssetReport
{
    public class CreateAuditCopyRequest : PlaidRequest
    {
        [JsonPropertyName("asset_report_token")]
        public string AssetReportToken { get; set; }

        [JsonPropertyName("auditor_id")]
        public string AuditorID { get; set; }
    }
}
