using Take5ive.Plaid.Accounts;
using Take5ive.Plaid.Item;

namespace Take5ive.Plaid.Investments
{
    public class GetHoldingsResponse : PlaidResponse
    {
        public Account[] Accounts { get; set; }
        public Holding[] Holdings { get; set; }
        public PlaidItem Item { get; set; }
        public Security[] Securities { get; set; }
    }
}
