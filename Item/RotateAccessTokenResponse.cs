using System.Text.Json.Serialization;

namespace Take5ive.Plaid.Item
{
    public class RotateAccessTokenResponse : PlaidResponse
    {
        [JsonPropertyName("new_access_token")]
        public string NewAccessToken { get; set; }
    }
}
