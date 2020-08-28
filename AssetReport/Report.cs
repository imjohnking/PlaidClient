using System;
using System.Text.Json.Serialization;

namespace Take5ive.Plaid.AssetReport
{
    public class Report
    {
        [JsonPropertyName("asset_report_id")]
        public string AssetReportID { get; set; }

        [JsonPropertyName("client_report_id")]
        public object ClientReportID { get; set; }

        [JsonPropertyName("date_generated")]
        public DateTime Dategenerated { get; set; }

        [JsonPropertyName("days_requested")]
        public int DaysRequested { get; set; }

        public ReportItem[] Items { get; set; }

        public User User { get; set; }
    }
}
