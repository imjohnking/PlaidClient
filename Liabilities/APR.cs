using System.Text.Json.Serialization;

namespace Take5ive.Plaid.Liabilities
{
    public class APR
    {
        [JsonPropertyName("apr_percentage")]
        public float APRPercentage { get; set; }

        [JsonPropertyName("apr_type")]
        public string APRType { get; set; }

        [JsonPropertyName("balance_subject_to_apr")]
        public float BalanceSubjectToAPR { get; set; }

        [JsonPropertyName("interest_charge_amount")]
        public float InterestChargeAmount { get; set; }
    }
}
