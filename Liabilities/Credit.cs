using System.Text.Json.Serialization;

namespace Take5ive.Plaid.Liabilities
{
    public class Credit
    {
        [JsonPropertyName("account_id")]
        public string AccountID { get; set; }

        public APR[] APRs { get; set; }

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

        [JsonPropertyName("minimum_payment_amount")]
        public int MinimumPaymentAmount { get; set; }

        [JsonPropertyName("next_payment_due_date")]
        public string NextPaymentDueDate { get; set; }
    }
}
