using System.Text.Json.Serialization;

namespace Take5ive.Plaid.Institutions
{
    public class GetInstitutionsRequest : PlaidRequest
    {
        public GetInstitutionsRequest()
        {
            Options = new RequestOptions();
        }

        public int Count { get; set; }

        public int Offset { get; set; }

        public RequestOptions Options { get; set; }

        public class RequestOptions
        {
            public RequestOptions()
            {
                OAuth = null;
            }

            public string[] Products { get; set; }

            [JsonPropertyName("include_optional_metadata")]
            public bool IncludeOptionalData { get; set; }

            [JsonPropertyName("country_codes")]
            public string[] CountryCodes { get; set; }

            [JsonPropertyName("routing_numbers")]
            public string[] RoutingNumbers { get; set; }

            [JsonPropertyName("oauth")]
            public bool? OAuth { get; set; } = false;
        }
    }
}
