using Take5ive.Plaid.Accounts;
using Take5ive.Plaid.Item;

namespace Take5ive.Plaid.Identity
{
    public class GetIdentityResponse : PlaidResponse
    {
        public Account[] Accounts { get; set; }
        public PlaidItem Item { get; set; }
    }
}
