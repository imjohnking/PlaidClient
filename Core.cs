using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Take5ive.Plaid
{
    internal static class Core
    {
        private static readonly JsonSerializerOptions _jsonOptions = new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };

        /// <summary>
        /// Sends reqeusts to Plaid API
        /// </summary>
        /// <param name="request">Request to send to Plaid's API.</param>
        /// <param name="httpClient">HttpClient to use for this request.</param>
        /// <param name="plaidConfig">Plaid client configuration data.</param>
        /// <returns>Plaid response data</returns>
        public static async Task<TResponse> SendRequest<TResponse>(PlaidRequest request, HttpClient httpClient, PlaidConfig plaidConfig = null) where TResponse : PlaidResponse
        {
            // if public key has not been set, add credentials
            // when using the public key, you don't need the credentials
            if (request.PublicKey == null && request.Authenticate)
            {
                request.ClientID = plaidConfig.ClientID;
                request.Secret = plaidConfig.Secret;
            }

            // prepare the request
            HttpContent content = new StringContent(request.Serialize());
            content.Headers.ContentType.MediaType = "application/json";

            // send the request
            var message = await httpClient.PostAsync(request.DestinationUri, content);

            // handle the response
            TResponse response = JsonSerializer.Deserialize<TResponse>(await message.Content.ReadAsStringAsync(), _jsonOptions);
            response.StatusCode = message.StatusCode;

            // handle any errors
            if (message.StatusCode != System.Net.HttpStatusCode.OK)
            {
                response.ErrorDetails = JsonSerializer.Deserialize<PlaidError>(await message.Content.ReadAsStringAsync(), _jsonOptions);
            }

            return response;
        }
    }
}
