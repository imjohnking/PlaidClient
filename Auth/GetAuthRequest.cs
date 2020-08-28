using System.Text.Json.Serialization;

namespace Take5ive.Plaid.Auth
{
    public class GetAuthRequest : PlaidRequest
    {
        public GetAuthRequest()
        {
            Options = new RequestOptions();
        }

        public RequestOptions Options { get; set; }

        public class RequestOptions
        {
            [JsonPropertyName("account_ids")]
            public string[] AccountIDs { get; set; }
        }
    }
}
