using System.Text.Json.Serialization;

namespace Take5ive.Plaid.Liabilities
{
    public class GetLiabilitiesRequest : PlaidRequest
    {
        public GetLiabilitiesRequest()
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
