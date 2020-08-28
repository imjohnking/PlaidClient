using System.Text.Json.Serialization;

namespace Take5ive.Plaid.Liabilities
{
    public class ServicerAddress
    {
        public string City { get; set; }

        public string Country { get; set; }

        [JsonPropertyName("postal_code")]
        public string PostalCode { get; set; }

        public string Region { get; set; }

        public string Street { get; set; }
    }
}
