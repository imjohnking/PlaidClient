namespace Take5ive.Plaid.AssetReport
{
    public class GetReportResponse : PlaidResponse
    {
        public Report Report { get; set; }
        public object[] Warnings { get; set; }
    }
}
