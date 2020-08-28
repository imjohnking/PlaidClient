using System.Text.Json.Serialization;
using Take5ive.Json.Attributes;

namespace Take5ive.Plaid.Institutions
{
    public class SearchInstitutionsRequest : PlaidRequest
    {
        private string[] _products;

        public SearchInstitutionsRequest()
        {
            _products = new string[] { };
            Options = new RequestOptions();
        }

        [JsonPropertyName("query")]
        public string InstitutionName { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Include)]
        public string[] Products
        {
            get
            {
                return _products?.Length > 0 ? _products : null;
            }
            set { _products = value; }
        }

        public RequestOptions Options { get; set; }

        public class RequestOptions
        {
            public RequestOptions()
            {
                OAuth = null;
            }

            [JsonPropertyName("include_optional_metadata")]
            public bool IncludeOptionalData { get; set; }

            [JsonPropertyName("country_codes")]
            public string[] CountryCodes { get; set; }

            [JsonPropertyName("routing_numbers")]
            public string[] RoutingNumbers { get; set; }

            [JsonPropertyName("oauth")]
            public bool? OAuth { get; set; }
        }
    }
}
