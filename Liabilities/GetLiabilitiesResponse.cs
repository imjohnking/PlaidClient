using Take5ive.Plaid.Accounts;
using Take5ive.Plaid.Item;

namespace Take5ive.Plaid.Liabilities
{
    public class GetLiabilitiesResponse : PlaidResponse
    {
        public Account[] Accounts { get; set; }
        public PlaidItem Item { get; set; }
        public Liabilities Liabilities { get; set; }
    }
}
