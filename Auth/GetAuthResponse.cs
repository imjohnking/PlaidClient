using Take5ive.Plaid.Accounts;
using Take5ive.Plaid.Item;

namespace Take5ive.Plaid.Auth
{
    public class GetAuthResponse : PlaidResponse
    {
        public Account[] Accounts { get; set; }
        public Item.PlaidItem Item { get; set; }
        public PlaidItemNumbers Numbers { get; set; }
    }
}
