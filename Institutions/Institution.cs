using System.Text.Json.Serialization;

namespace Take5ive.Plaid.Institutions
{
    public class Institution
    {
        [JsonPropertyName("country_codes")]
        public string[] CountryCodes { get; set; }

        public Credential[] Credentials { get; set; }

        [JsonPropertyName("has_mfa")]
        public bool HasMFA { get; set; }

        [JsonPropertyName("input_spec")]
        public string InputSpec { get; set; }

        [JsonPropertyName("institution_id")]
        public string InstitutionID { get; set; }

        public object Logo { get; set; }

        [JsonPropertyName("mfa")]
        public string[] MFA { get; set; }

        [JsonPropertyName("mfa_code_type")]
        public string MFACodeType { get; set; }

        public string Name { get; set; }

        [JsonPropertyName("oauth")]
        public bool OAuth { get; set; }

        [JsonPropertyName("primary_color")]
        public string PrimaryColor { get; set; }

        public string[] Products { get; set; }

        [JsonPropertyName("routing_numbers")]
        public object[] RoutingNumbers { get; set; }

        public Status Status { get; set; }

        [JsonPropertyName("url")]
        public string URL { get; set; }
    }
}
