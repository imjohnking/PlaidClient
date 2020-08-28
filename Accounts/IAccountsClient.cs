using System.Threading.Tasks;

namespace Take5ive.Plaid.Accounts
{
    /// <summary>
    /// Handles all of the Auth related requests to the Plaid API.
    /// </summary>
    public interface IAccountsClient
    {
        /// <summary>
        /// Retrieve information for any linked bank account
        /// </summary>
        /// <param name="accessToken">Plaid access token for this item</param>
        /// <returns>All accounts for the specified access token</returns>
        /// <remarks>
        /// https://plaid.com/docs/#accounts
        /// </remarks>
        public Task<GetAccountsResponse> GetAccounts(string accessToken);

        /// <summary>
        /// Returns the real-time balance for each of an Item's accounts
        /// </summary>
        /// <param name="request">Plaid request parameters</param>
        /// <returns>Balance Details for one or more requested accounts</returns>
        /// <remarks>https://plaid.com/docs/#balance</remarks>
        public Task<GetBalanceResponse> GetBalance(GetBalanceRequest request);
    }
}
