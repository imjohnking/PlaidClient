using System.Text.Json.Serialization;

namespace Take5ive.Plaid.AssetReport
{
    public class User
    {
        [JsonPropertyName("client_user_id")]
        public string ClientUserID { get; set; }

        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        [JsonPropertyName("middle_name")]
        public string MiddleName { get; set; }

        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        public string SSN { get; set; }

        [JsonPropertyName("phone_number")]
        public string PhoneNumber { get; set; }

        public string Email { get; set; }
    }
}
