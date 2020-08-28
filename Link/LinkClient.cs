using System.Net.Http;
using System.Threading.Tasks;
using static Take5ive.Plaid.Core;

namespace Take5ive.Plaid.Link
{
    /// <summary>
    /// Handles all of the Link related requests to the Plaid API.
    /// </summary>
    public class LinkClient : ILinkClient
    {
        private readonly HttpClient _httpClient;
        private readonly PlaidConfig _plaidConfig;

        public LinkClient(HttpClient httpClient, PlaidConfig plaidConfig)
        {
            _httpClient = httpClient;
            _plaidConfig = plaidConfig;
        }

        /// <summary>
        /// In order to initialize Link, you will need to create a link_token. A link_token can be
        /// configured for different Link flows depending on the fields provided during token creation.
        /// It is ephemeral and has a short lived expiration.
        /// </summary>
        /// <param name="request">Request object containing desired Plaid parameters.</param>
        /// <returns>Response object containing the link token.</returns>
        /// <remarks>https://plaid.com/docs/#create-link-token</remarks>
        public async Task<GetLinkTokenResponse> GetLinkToken(GetLinkTokenRequest request)
        {
            request.DestinationUri = "link/token/create";
            return await SendRequest<GetLinkTokenResponse>(request, _httpClient, _plaidConfig);
        }
    }
}
