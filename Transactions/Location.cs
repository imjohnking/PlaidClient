using System.Text.Json.Serialization;

namespace Take5ive.Plaid.Transactions
{
    public class Location
    {
        public object Address { get; set; }
        public object City { get; set; }
        public object Country { get; set; }
        public object Lat { get; set; }
        public object Lon { get; set; }

        [JsonPropertyName("postal_code")]
        public object PostalCode { get; set; }

        public object Region { get; set; }

        [JsonPropertyName("store_number")]
        public string StoreNumber { get; set; }
    }
}
