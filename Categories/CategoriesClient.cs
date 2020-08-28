using System.Net.Http;
using System.Threading.Tasks;
using static Take5ive.Plaid.Core;

namespace Take5ive.Plaid.Categories
{
    public class CategoriesClient : ICategoriesClient
    {
        private readonly HttpClient _httpClient;
        private readonly PlaidConfig _plaidConfig;

        public CategoriesClient(HttpClient httpClient, PlaidConfig plaidConfig)
        {
            _httpClient = httpClient;
            _plaidConfig = plaidConfig;
        }

        /// <summary>
        /// Get a list of transaction categories from Plaid.
        /// </summary>
        /// <returns>List of transaction categories.</returns>
        /// <remarks>https://plaid.com/docs/#category-overview</remarks>
        public async Task<GetCategoriesResponse> GetCategories()
        {
            var request = new GetCategoriesRequest()
            {
                DestinationUri = "categories/get"
            };

            return await SendRequest<GetCategoriesResponse>(request, _httpClient, _plaidConfig);
        }
    }
}
