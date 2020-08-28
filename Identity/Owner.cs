using System.Text.Json.Serialization;

namespace Take5ive.Plaid.Identity
{
    public class Owner
    {
        public Address[] Addresses { get; set; }
        public Email[] Emails { get; set; }
        public string[] Names { get; set; }

        [JsonPropertyName("phone_numbers")]
        public PhoneNumbers[] PhoneNumbers { get; set; }
    }
}
