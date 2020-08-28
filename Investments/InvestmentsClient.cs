using System.Net.Http;
using System.Threading.Tasks;
using static Take5ive.Plaid.Core;

namespace Take5ive.Plaid.Investments
{
    /// <summary>
    /// Handles all of the Investments related requests to the Plaid API.
    /// </summary>
    public class InvestmentsClient : IInvestmentsClient
    {
        private readonly HttpClient _httpClient;
        private readonly PlaidConfig _plaidConfig;

        public InvestmentsClient(HttpClient httpClient, PlaidConfig plaidConfig)
        {
            _httpClient = httpClient;
            _plaidConfig = plaidConfig;
        }

        /// <summary>
        /// Retrieve user-authorized Holding, Security, and Investment Transactions data for a wide array of investment account and security types.
        /// </summary>
        /// <param name="request">Request object containing desired Plaid parameters.</param>
        /// <returns>Investment data.</returns>
        /// <remarks>https://plaid.com/docs/#retrieve-holdings-request</remarks>
        public async Task<GetHoldingsResponse> GetHoldings(GetHoldingsRequest request)
        {
            request.DestinationUri = "investments/holdings/get";
            return await SendRequest<GetHoldingsResponse>(request, _httpClient, _plaidConfig);
        }

        /// <summary>
        /// Retrieve user-authorized transaction data for investment accounts.
        /// </summary>
        /// <param name="request">Request object containing desired Plaid parameters.</param>
        /// <returns>Transaction details.</returns>
        /// <remarks>https://plaid.com/docs/#retrieve-investment-transactions-request</remarks>
        public async Task<GetTransactionsResponse> GetTransactions(GetTransactionsRequest request)
        {
            request.DestinationUri = "investments/transactions/get";
            return await SendRequest<GetTransactionsResponse>(request, _httpClient, _plaidConfig);
        }
    }
}
