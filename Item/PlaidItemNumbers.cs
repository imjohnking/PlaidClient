using Take5ive.Plaid.Accounts;

namespace Take5ive.Plaid.Item
{
    public class PlaidItemNumbers
    {
        public ACHInfo[] ACH { get; set; }
        public object[] BACS { get; set; }
        public object[] EFT { get; set; }
        public object[] International { get; set; }
    }
}
