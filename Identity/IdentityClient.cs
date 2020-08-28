using System.Net.Http;
using System.Threading.Tasks;
using static Take5ive.Plaid.Core;

namespace Take5ive.Plaid.Identity
{
    public class IdentityClient : IIdentityClient
    {
        private readonly HttpClient _httpClient;
        private readonly PlaidConfig _plaidConfig;

        public IdentityClient(HttpClient httpClient, PlaidConfig plaidConfig)
        {
            _httpClient = httpClient;
            _plaidConfig = plaidConfig;
        }

        /// <summary>
        /// Retrieve various account holder information on file with the financial institution, including names, emails, phone numbers, and addresses.
        /// </summary>
        /// <param name="accessToken">Access token of the item to get the identity for.</param>
        /// <returns>Identity information.</returns>
        /// <remarks>https://plaid.com/docs/#identity</remarks>
        public async Task<GetIdentityResponse> GetIdentity(string accessToken)
        {
            var request = new PlaidRequest()
            {
                AccessToken = accessToken
            };

            request.DestinationUri = "identity/get";
            return await SendRequest<GetIdentityResponse>(request, _httpClient, _plaidConfig);
        }
    }
}
