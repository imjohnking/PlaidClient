using System.Text.Json.Serialization;

namespace Take5ive.Plaid.Link
{
    public class AccountFilters
    {
        public SubTypeFilter Depository { get; set; }
        public SubTypeFilter Credit { get; set; }
        public SubTypeFilter Investment { get; set; }
        public SubTypeFilter Loan { get; set; }
        public SubTypeFilter Other { get; set; }

        public class SubTypeFilter
        {
            [JsonPropertyName("account_subtypes")]
            public string[] AccountSubtypes { get; set; }
        }
    }
}
