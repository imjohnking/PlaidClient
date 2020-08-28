using Take5ive.Plaid.Item;

namespace Take5ive.Plaid.Accounts
{
    /// <summary>
    /// Contains response data for a GetBalanceRequest
    /// </summary>
    public class GetBalanceResponse : PlaidResponse
    {
        /// <summary>
        /// Accounts retreived
        /// </summary>
        public Account[] Accounts { get; set; }

        /// <summary>
        /// Plaid Item Details
        /// </summary>
        public PlaidItem Item { get; set; }
    }
}
