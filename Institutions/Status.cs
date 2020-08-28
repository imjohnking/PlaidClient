using System.Text.Json.Serialization;

namespace Take5ive.Plaid.Institutions
{
    public class Status
    {
        [JsonPropertyName("item_logins")]
        public object ItemLogins { get; set; }
    }
}
