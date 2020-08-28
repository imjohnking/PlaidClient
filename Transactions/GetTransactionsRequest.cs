using System.Text.Json.Serialization;

namespace Take5ive.Plaid.Transactions
{
    public class GetTransactionsRequest : PlaidRequest
    {
        public GetTransactionsRequest()
        {
            Options = new RequestOptions();
        }

        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }

        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        public RequestOptions Options { get; set; }

        public class RequestOptions
        {
            [JsonPropertyName("account_ids")]
            public string[] AccountIDs { get; set; }

            public int Count { get; set; }

            public int Offset { get; set; }
        }
    }
}
