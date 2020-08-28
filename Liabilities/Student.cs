using System.Text.Json.Serialization;

namespace Take5ive.Plaid.Liabilities
{
    public class Student
    {
        [JsonPropertyName("account_id")]
        public string AccountID { get; set; }

        [JsonPropertyName("account_number")]
        public string AccountNumber { get; set; }

        [JsonPropertyName("disbursement_dates")]
        public string[] DisbursementDates { get; set; }

        [JsonPropertyName("expected_payoff_date")]
        public string ExpectedPayoffDate { get; set; }

        public string Guarantor { get; set; }

        [JsonPropertyName("interest_rate_percentage")]
        public float interest_rate_percentage { get; set; }

        [JsonPropertyName("is_overdue")]
        public bool IsOverdue { get; set; }

        [JsonPropertyName("last_payment_amount")]
        public float LastPaymentAmount { get; set; }

        [JsonPropertyName("last_payment_date")]
        public string LastPaymentDate { get; set; }

        [JsonPropertyName("last_statement_balance")]
        public float LastStatementBalance { get; set; }

        [JsonPropertyName("last_statement_issue_date")]
        public string LastStatementIssueDate { get; set; }

        [JsonPropertyName("loan_name")]
        public string LoanName { get; set; }

        [JsonPropertyName("loan_status")]
        public LoanStatus LoanStatus { get; set; }

        [JsonPropertyName("minimum_payment_amount")]
        public int MinimumPaymentAmount { get; set; }

        [JsonPropertyName("next_payment_due_date")]
        public string NextPaymentDueDate { get; set; }

        [JsonPropertyName("origination_date")]
        public string OriginationDate { get; set; }

        [JsonPropertyName("origination_principal_amount")]
        public int OriginationPrincipalAmount { get; set; }

        [JsonPropertyName("outstanding_interest_amount")]
        public float OutstandingInterestAmount { get; set; }

        [JsonPropertyName("payment_reference_number")]
        public string PaymentReferenceNumber { get; set; }

        [JsonPropertyName("pslf_status")]
        public PslfStatus PslfStatus { get; set; }

        [JsonPropertyName("repayment_plan")]
        public RepaymentPlan RepaymentPlan { get; set; }

        [JsonPropertyName("sequence_number")]
        public string SequenceNumber { get; set; }

        [JsonPropertyName("servicer_address")]
        public ServicerAddress ServicerAddress { get; set; }

        [JsonPropertyName("ytd_interest_paid")]
        public float YTDInterestPaid { get; set; }

        [JsonPropertyName("ytd_principal_paid")]
        public float YTDPrincipalPaid { get; set; }
    }
}
