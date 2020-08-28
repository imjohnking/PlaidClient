using System.Text.Json.Serialization;

namespace Take5ive.Plaid.Liabilities
{
    public class LoanStatus
    {
        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        public string Type { get; set; }
    }
}
