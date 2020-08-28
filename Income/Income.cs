using System.Text.Json.Serialization;

namespace Take5ive.Plaid.Income
{
    public class Income
    {
        [JsonPropertyName("income_streams")]
        public Income_Streams[] IncomeStreams { get; set; }

        [JsonPropertyName("last_year_income")]
        public int LastYearIncome { get; set; }

        [JsonPropertyName("last_year_income_before_tax")]
        public int LastYearIncomeBeforeTax { get; set; }

        [JsonPropertyName("max_number_of_overlapping_income_streams")]
        public int MaxNumberOfOverlappingIncomeStreams { get; set; }

        [JsonPropertyName("number_of_income_streams")]
        public int NumberOfIncomeStreams { get; set; }

        [JsonPropertyName("projected_yearly_income")]
        public int ProjectedYearlyIncome { get; set; }

        [JsonPropertyName("projected_yearly_income_before_tax")]
        public int ProjectedYearlyIncomeBeforeTax { get; set; }
    }
}
