using System.Text.Json.Serialization;

namespace Take5ive.Plaid.Link
{
    public class User
    {
        [JsonPropertyName("client_user_id")]
        public string ClientUserId { get; set; }
    }
}
