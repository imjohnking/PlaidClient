namespace Take5ive.Plaid.Institutions
{
    public class GetInstitutionsResponse : PlaidResponse
    {
        public Institution[] Institutions { get; set; }

        public int Total { get; set; }
    }
}
