using System.Text.Json.Serialization;

namespace Take5ive.Plaid
{
    public class PlaidError
    {
        [JsonPropertyName("display_message")]
        public string DisplayMessage { get; set; }

        [JsonPropertyName("documentation_url")]
        public string DocumentationURL { get; set; }

        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        [JsonPropertyName("error_message")]
        public string ErrorMessage { get; set; }

        [JsonPropertyName("error_type")]
        public string ErrorType { get; set; }

        [JsonPropertyName("suggested_action")]
        public string SuggestedAction { get; set; }
    }
}
