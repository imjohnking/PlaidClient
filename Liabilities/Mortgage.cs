using System.Text.Json.Serialization;

namespace Take5ive.Plaid.Liabilities
{
    public class Mortgage
    {
        [JsonPropertyName("account_id")]
        public string AccountID { get; set; }

        [JsonPropertyName("account_number")]
        public string AccountNumber { get; set; }

        [JsonPropertyName("current_late_fee")]
        public int CurrentLateFee { get; set; }

        [JsonPropertyName("escrow_balance")]
        public float EscrowBalance { get; set; }

        [JsonPropertyName("has_pmi")]
        public bool HasPMI { get; set; }

        [JsonPropertyName("has_prepayment_penalty")]
        public bool HasPrepaymentPpenalty { get; set; }

        [JsonPropertyName("interest_rate")]
        public InterestRate Interestrate { get; set; }

        [JsonPropertyName("last_payment_amount")]
        public float LastPaymentAmount { get; set; }

        [JsonPropertyName("last_payment_date")]
        public string LastPaymentDate { get; set; }

        [JsonPropertyName("loan_term")]
        public string LoanTerm { get; set; }

        [JsonPropertyName("loan_type_description")]
        public string LoanTypeDescription { get; set; }

        [JsonPropertyName("maturity_date")]
        public string MaturityDate { get; set; }

        [JsonPropertyName("next_monthly_payment")]
        public float NextMonthlyPayment { get; set; }

        [JsonPropertyName("next_payment_due_date")]
        public object NextPaymentDueDate { get; set; }

        [JsonPropertyName("origination_date")]
        public string OriginationDate { get; set; }

        [JsonPropertyName("origination_principal_amount")]
        public int OriginationPrincipalAmount { get; set; }

        [JsonPropertyName("past_due_amount")]
        public int PastDueAmount { get; set; }

        [JsonPropertyName("property_address")]
        public PropertyAddress PropertyAddress { get; set; }

        [JsonPropertyName("ytd_interest_paid")]
        public float YTDInterestPaid { get; set; }

        [JsonPropertyName("ytd_principal_paid")]
        public float YTDPrincipalPaid { get; set; }
    }
}
