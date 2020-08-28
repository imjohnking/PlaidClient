using System.Net.Http;
using System.Threading.Tasks;
using static Take5ive.Plaid.Core;

namespace Take5ive.Plaid.Transactions
{
    public class TransactionsClient : ITransactionsClient
    {
        private readonly HttpClient _httpClient;
        private readonly PlaidConfig _plaidConfig;

        public TransactionsClient(HttpClient httpClient, PlaidConfig plaidConfig)
        {
            _httpClient = httpClient;
            _plaidConfig = plaidConfig;
        }

        /// <summary>
        /// Get account transactions from Plaid
        /// </summary>
        /// <param name="request">Request object containing desired Plaid parameters.</param>
        /// <returns>List of account transactions.</returns>
        /// <remarks>https://plaid.com/docs/#transactions</remarks>
        public async Task<GetTransactionsResponse> GetTransactions(GetTransactionsRequest request)
        {
            request.DestinationUri = "transactions/get";
            return await SendRequest<GetTransactionsResponse>(request, _httpClient, _plaidConfig);
        }

        /// <summary>
        /// Initiates an on-demand extraction to fetch the newest transactions for an item.
        /// </summary>
        /// <param name="accessToken">Access token for the item to refresh transactions for.</param>
        /// <returns>Successful request returns HttpStatusCode 200.</returns>
        /// <remarks>https://plaid.com/docs/#transactions-refresh</remarks>
        public async Task<PlaidResponse> RefreshTransactions(string accessToken)
        {
            var request = new PlaidRequest()
            {
                AccessToken = accessToken
            };

            request.DestinationUri = "transactions/refresh";
            return await SendRequest<PlaidResponse>(request, _httpClient, _plaidConfig);
        }
    }
}
