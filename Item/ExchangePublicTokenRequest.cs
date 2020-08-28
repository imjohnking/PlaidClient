using System.Text.Json.Serialization;

namespace Take5ive.Plaid.Item
{
    public class ExchangePublicTokenRequest : PlaidRequest
    {
        [JsonPropertyName("public_token")]
        public string PublicToken { get; set; }
    }
}
