using System.Text.Json.Serialization;

namespace Take5ive.Plaid.AssetReport
{
    public class CreateReportRequest : PlaidRequest
    {
        public CreateReportRequest()
        {
            Options = new RequestOptions
            {
                User = new User()
            };
        }

        [JsonPropertyName("access_tokens")]
        public string[] AccessTokens { get; set; }

        [JsonPropertyName("days_requested")]
        public int DaysRequested { get; set; }

        public RequestOptions Options { get; set; }

        [JsonIgnore]
        new public string AccessToken
        {
            get { return AccessTokens.Length > 0 ? AccessTokens[0] : string.Empty; }
            set
            {
                AccessTokens = new string[] { value };
            }
        }

        public class RequestOptions
        {
            [JsonPropertyName("client_report_id")]
            public string ClientReportID { get; set; }

            public string Webhook { get; set; }

            public User User { get; set; }
        }
    }
}
