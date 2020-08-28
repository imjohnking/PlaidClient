using System.Text.Json.Serialization;

namespace Take5ive.Plaid.Income
{
    public class Income_Streams
    {
        public float Confidence { get; set; }

        public int Days { get; set; }

        [JsonPropertyName("monthly_income")]
        public int MonthlyIncome { get; set; }

        public string Name { get; set; }
    }
}
