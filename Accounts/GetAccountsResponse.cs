using Take5ive.Plaid.Item;

namespace Take5ive.Plaid.Accounts
{
    /// <summary>
    /// Accounts held at an institution
    /// </summary>
    public class GetAccountsResponse : PlaidResponse
    {
        /// <summary>
        /// Accounts and account details
        /// </summary>
        public Account[] Accounts { get; set; }

        /// <summary>
        /// Details regarding the Plaid "item"
        /// </summary>
        /// <remarks>
        /// An item is a set of credentials at a financial institution; each Item 
        /// can have many Accounts, and some Accounts have Transactions associated with them
        /// </remarks>
        public PlaidItem Item { get; set; }
    }
}
