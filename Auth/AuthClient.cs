using System.Net.Http;
using System.Threading.Tasks;
using static Take5ive.Plaid.Core;

namespace Take5ive.Plaid.Auth
{
    public class AuthClient : IAuthClient
    {
        private readonly HttpClient _httpClient;
        private readonly PlaidConfig _plaidConfig;

        public AuthClient(HttpClient httpClient, PlaidConfig plaidConfig)
        {
            _httpClient = httpClient;
            _plaidConfig = plaidConfig;
        }

        /// <summary>
        /// Get "item" details from the Plaid API for a specified Access Token
        /// </summary>
        /// <param name="request">Request object containing desired Plaid parameters.</param>
        /// <returns>All accounts for the specified access token.</returns>
        /// <remarks>
        /// https://plaid.com/docs/#auth
        /// </remarks>
        public async Task<GetAuthResponse> GetAuth(GetAuthRequest request)
        {
            request.DestinationUri = "auth/get";
            return await SendRequest<GetAuthResponse>(request, _httpClient, _plaidConfig);
        }
    }
}
