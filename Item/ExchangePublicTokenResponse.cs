using System.Text.Json.Serialization;

namespace Take5ive.Plaid.Item
{
    public class ExchangePublicTokenResponse : PlaidResponse
    {
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }

        [JsonPropertyName("item_id")]
        public string ItemID { get; set; }
    }
}
