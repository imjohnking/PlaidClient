using System.Net.Http;
using System.Threading.Tasks;
using static Take5ive.Plaid.Core;

namespace Take5ive.Plaid.Item
{
    /// <summary>
    /// Handles all of the Item related requests to the Plaid API.
    /// </summary>
    public class ItemClient : IItemClient
    {
        private readonly HttpClient _httpClient;
        private readonly PlaidConfig _plaidConfig;

        public ItemClient(HttpClient httpClient, PlaidConfig plaidConfig)
        {
            _httpClient = httpClient;
            _plaidConfig = plaidConfig;
        }

        /// <summary>
        /// Exchange public_token received from Plaid Link for the private access_token.
        /// </summary>
        /// <param name="request">Request object containing desired Plaid parameters.</param>
        /// <returns>Private access token and item id.</returns>
        /// <remarks>https://plaid.com/docs/#exchange-token-flow</remarks>
        public async Task<ExchangePublicTokenResponse> ExchangePublicToken(ExchangePublicTokenRequest request)
        {
            request.DestinationUri = "item/public_token/exchange";
            return await SendRequest<ExchangePublicTokenResponse>(request, _httpClient, _plaidConfig);
        }

        /// <summary>
        /// Get a public token that can be used in place of an access token with Plaid Link.
        /// </summary>
        /// <param name="accessToken">Access token to get the public token for.</param>
        /// <returns>Public token that can be used with Plaid Link.</returns>
        /// <remarks>https://plaid.com/docs/#creating-public-tokens</remarks>
        public async Task<GetPublicTokenResponse> GetPublicToken(string accessToken)
        {
            var request = new PlaidRequest()
            {
                AccessToken = accessToken
            };

            request.DestinationUri = "item/public_token/create";
            return await SendRequest<GetPublicTokenResponse>(request, _httpClient, _plaidConfig);
        }

        /// <summary>
        /// Update the webhook URL for a Plaid Item.
        /// </summary>
        /// <param name="request">Request object containing desired Plaid parameters.</param>
        /// <returns>Updated item information.</returns>
        /// <remarks>https://plaid.com/docs/#update-webhook</remarks>
        public async Task<UpdateWebhookResponse> UpdateWebhook(UpdateWebhookRequest request)
        {
            request.DestinationUri = "item/webhook/update";
            return await SendRequest<UpdateWebhookResponse>(request, _httpClient, _plaidConfig);
        }

        /// <summary>
        /// Get an "item" from Plaid.
        /// </summary>
        /// <param name="request">Request object containing desired Plaid parameters.</param>
        /// <returns>Plaid "item".</returns>
        /// <remarks>https://plaid.com/docs/#retrieve-item</remarks>
        public async Task<GetItemResponse> GetItem(string accessToken)
        {
            var request = new PlaidRequest()
            {
                AccessToken = accessToken
            };

            request.DestinationUri = "item/get";
            return await SendRequest<GetItemResponse>(request, _httpClient, _plaidConfig);
        }

        /// <summary>
        /// Rotate/Invalidate an existing access token.
        /// </summary>
        /// <param name="request">Request object containing desired Plaid parameters.</param>
        /// <returns>Updated/New access token.</returns>
        /// <remarks>https://plaid.com/docs/#rotate-access-token</remarks>
        public async Task<RotateAccessTokenResponse> RotateAccessToken(string accessToken)
        {
            var request = new PlaidRequest()
            {
                AccessToken = accessToken
            };

            request.DestinationUri = "item/access_token/invalidate";
            return await SendRequest<RotateAccessTokenResponse>(request, _httpClient, _plaidConfig);
        }

        /// <summary>
        /// Delete/Remove an "item" from Plaid.
        /// </summary>
        /// <param name="request">Request object containing desired Plaid parameters.</param>
        /// <returns>Boolean value indicating success.</returns>
        /// <remarks>https://plaid.com/docs/#remove-an-item</remarks>
        public async Task<RemoveItemResponse> RemoveItem(string accessToken)
        {
            var request = new PlaidRequest()
            {
                AccessToken = accessToken
            };

            request.DestinationUri = "item/remove";
            return await SendRequest<RemoveItemResponse>(request, _httpClient, _plaidConfig);
        }
    }
}
