using System.Net.Http;
using System.Threading.Tasks;
using static Take5ive.Plaid.Core;

namespace Take5ive.Plaid.Accounts
{
    /// <summary>
    /// Handles all of the Auth related requests to the Plaid API.
    /// </summary>
    public class AccountsClient : IAccountsClient
    {
        private readonly HttpClient _httpClient;
        private readonly PlaidConfig _plaidConfig;

        /// <summary>
        /// Constructor for the AccountsClient
        /// </summary>
        /// <param name="httpClient">HttpClient to use for all requests</param>
        /// <param name="plaidConfig">Plaid configuration values specific to caller</param>
        public AccountsClient(HttpClient httpClient, PlaidConfig plaidConfig)
        {
            _httpClient = httpClient;
            _plaidConfig = plaidConfig;
        }

        /// <summary>
        /// Retrieve information for any linked bank account
        /// </summary>
        /// <param name="accessToken">Plaid access token for this item</param>
        /// <returns>All accounts for the specified access token</returns>
        /// <remarks>
        /// https://plaid.com/docs/#accounts
        /// </remarks>
        public async Task<GetAccountsResponse> GetAccounts(string accessToken)
        {
            var request = new PlaidRequest()
            {
                AccessToken = accessToken
            };

            request.DestinationUri = "accounts/get";
            return await SendRequest<GetAccountsResponse>(request, _httpClient, _plaidConfig);
        }

        /// <summary>
        /// Returns the real-time balance for each of an Item's accounts
        /// </summary>
        /// <param name="request">Plaid request parameters</param>
        /// <returns>Balance Details for one or more requested accounts</returns>
        /// <remarks>https://plaid.com/docs/#balance</remarks>
        public async Task<GetBalanceResponse> GetBalance(GetBalanceRequest request)
        {
            request.DestinationUri = "accounts/balance/get";
            return await SendRequest<GetBalanceResponse>(request, _httpClient, _plaidConfig);
        }
    }
}
