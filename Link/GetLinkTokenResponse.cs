using System;
using System.Text.Json.Serialization;

namespace Take5ive.Plaid.Link
{
    public class GetLinkTokenResponse : PlaidResponse
    {
        public DateTime Expiration { get; set; }

        [JsonPropertyName("link_token")]
        public string LinkToken { get; set; }
    }
}
