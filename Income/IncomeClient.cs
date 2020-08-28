using System.Net.Http;
using System.Threading.Tasks;
using static Take5ive.Plaid.Core;

namespace Take5ive.Plaid.Income
{
    public class IncomeClient : IIncomeClient
    {
        private readonly HttpClient _httpClient;
        private readonly PlaidConfig _plaidConfig;

        public IncomeClient(HttpClient httpClient, PlaidConfig plaidConfig)
        {
            _httpClient = httpClient;
            _plaidConfig = plaidConfig;
        }

        /// <summary>
        /// Retrieve information pertaining to a Item’s income.
        /// </summary>
        /// <param name="accessToken"></param>
        /// <returns>Detailed income information</returns>
        /// <remarks>https://plaid.com/docs/#income</remarks>
        public async Task<GetIncomeResponse> GetIncome(string accessToken)
        {
            var request = new PlaidRequest()
            {
                AccessToken = accessToken
            };

            request.DestinationUri = "income/get";
            return await SendRequest<GetIncomeResponse>(request, _httpClient, _plaidConfig);
        }
    }
}
