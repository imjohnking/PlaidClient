using System;
using System.Text.Json.Serialization;
using Take5ive.Plaid.Accounts;

namespace Take5ive.Plaid.AssetReport
{
    public class ReportItem
    {
        public Account[] Accounts { get; set; }

        [JsonPropertyName("date_last_updated")]
        public DateTime DateLastUpdated { get; set; }

        [JsonPropertyName("institution_id")]
        public string InstitutionID { get; set; }

        [JsonPropertyName("institution_name")]
        public string InstitutionName { get; set; }

        [JsonPropertyName("item_id")]
        public string ItemID { get; set; }
    }
}
