using System;
using System.Text.Json.Serialization;

namespace Take5ive.Plaid.Item
{
    public class GetPublicTokenResponse : PlaidResponse
    {
        public DateTime Expiration { get; set; }

        [JsonPropertyName("public_token")]
        public string PublicToken { get; set; }
    }
}
