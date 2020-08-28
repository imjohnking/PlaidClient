using System.Text.Json.Serialization;

namespace Take5ive.Plaid.AssetReport
{
    public class RefreshReportRequest : PlaidRequest
    {
        public RefreshReportRequest()
        {
            Options = new RequestOptions
            {
                User = new User()
            };
        }

        [JsonPropertyName("asset_report_token")]
        public string AssetReportToken { get; set; }

        [JsonPropertyName("days_requested")]
        public int DaysRequested { get; set; }

        public RequestOptions Options { get; set; }

        public class RequestOptions
        {
            [JsonPropertyName("client_report_id")]
            public string ClientReportID { get; set; }

            public string Webhook { get; set; }

            public User User { get; set; }
        }
    }
}
