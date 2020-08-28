using System.Text.Json.Serialization;

namespace Take5ive.Plaid.Investments
{
    public class GetHoldingsRequest : PlaidRequest
    {
        public GetHoldingsRequest()
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
