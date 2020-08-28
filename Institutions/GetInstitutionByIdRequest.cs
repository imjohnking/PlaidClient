using System.Text.Json.Serialization;

namespace Take5ive.Plaid.Institutions
{
    public class GetInstitutionByIdRequest : PlaidRequest
    {
        public GetInstitutionByIdRequest()
        {
            Options = new RequestOptions();
        }

        [JsonPropertyName("institution_id")]
        public string InstitutionID { get; set; }

        public RequestOptions Options { get; set; }

        public class RequestOptions
        {
            [JsonPropertyName("include_optional_metadata")]
            public bool IncludeOptionalData { get; set; }

            [JsonPropertyName("include_status")]
            public bool IncludeStatus { get; set; }
        }
    }
}
