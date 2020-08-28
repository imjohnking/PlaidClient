using System.Text.Json.Serialization;

namespace Take5ive.Plaid
{
    public class PlaidConfig
    {
        public const string PlaidClient = "PlaidClient";

        public string BaseUrl { get; set; }

        public string ClientID { get; set; }

        public string Secret { get; set; }

        public string PublicKey { get; set; }
    }
}
