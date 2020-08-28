using System.Text.Json.Serialization;

namespace Take5ive.Plaid.Liabilities
{
    public class PslfStatus
    {
        [JsonPropertyName("estimated_eligibility_date")]
        public string EstimatedEligibilityDate { get; set; }

        [JsonPropertyName("payments_made")]
        public int PaymentsMade { get; set; }

        [JsonPropertyName("payments_remaining")]
        public int PaymentsRemaining { get; set; }
    }
}
