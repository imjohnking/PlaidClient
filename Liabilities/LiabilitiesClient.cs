using System.Net.Http;
using System.Threading.Tasks;
using static Take5ive.Plaid.Core;

namespace Take5ive.Plaid.Liabilities
{
    /// <summary>
    /// Handles all of the Liability related requests to the Plaid API.
    /// </summary>
    public class LiabilitiesClient : ILiabilitiesClient
    {
        private readonly HttpClient _httpClient;
        private readonly PlaidConfig _plaidConfig;

        public LiabilitiesClient(HttpClient httpClient, PlaidConfig plaidConfig)
        {
            _httpClient = httpClient;
            _plaidConfig = plaidConfig;
        }

        /// <summary>
        /// Retrieve various details about an Item with loan or credit accounts.
        /// </summary>
        /// <param name="request">Request object containing desired Plaid parameters.</param>
        /// <returns>Liability details.</returns>
        /// <remarks>https://plaid.com/docs/#retrieve-liabilities-request</remarks>
        public async Task<GetLiabilitiesResponse> GetLiabilities(GetLiabilitiesRequest request)
        {
            request.DestinationUri = "liabilities/get";
            return await SendRequest<GetLiabilitiesResponse>(request, _httpClient, _plaidConfig);
        }
    }
}
