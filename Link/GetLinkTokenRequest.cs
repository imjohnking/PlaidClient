using System.Text.Json.Serialization;

namespace Take5ive.Plaid.Link
{
    public class GetLinkTokenRequest : PlaidRequest
    {
        [JsonPropertyName("client_name")]
        public string ClientName { get; set; }

        public string Language { get; set; }

        [JsonPropertyName("country_codes")]
        public string[] CountryCodes { get; set; }

        public User User { get; set; }

        public string[] Products { get; set; }

        public string Webhook { get; set; }

        [JsonPropertyName("link_customization_name")]
        public string LinkCustomizationName { get; set; }

        [JsonPropertyName("account_filters")]
        public AccountFilters AccountFilters { get; set; }

        [JsonPropertyName("redirect_uri")]
        public string RedirectUri { get; set; }

        [JsonPropertyName("android_package_name")]
        public string AndroidPackageName { get; set; }

        [JsonPropertyName("payment_initiation")]
        public PaymentInitiation PaymentInitiation { get; set; }
    }
}
