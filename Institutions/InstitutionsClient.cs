using System.Net.Http;
using System.Threading.Tasks;
using static Take5ive.Plaid.Core;

namespace Take5ive.Plaid.Institutions
{
    /// <summary>
    /// Handles all of the institution related requests to the Plaid API.
    /// </summary>
    public class InstitutionsClient : IInstitutionsClient
    {
        private readonly HttpClient _httpClient;
        private readonly PlaidConfig _plaidConfig;

        public InstitutionsClient(HttpClient httpClient, PlaidConfig plaidConfig)
        {
            _httpClient = httpClient;
            _plaidConfig = plaidConfig;
        }

        /// <summary>
        /// Get a list of institutions from the Plaid API
        /// </summary>
        /// <param name="request">Request object containing desired Plaid parameters.</param>
        /// <returns>List of requested institutions</returns>
        /// <remarks>
        /// https://plaid.com/docs/#all-institutions
        /// To get all institutions, you will have to call this function more than once while utilizing the offset param.
        /// </remarks>
        public async Task<GetInstitutionsResponse> GetInstitutions(GetInstitutionsRequest request)
        {
            request.DestinationUri = "institutions/get";
            return await SendRequest<GetInstitutionsResponse>(request, _httpClient, _plaidConfig);
        }

        /// <summary>
        /// Get a specific institution from the Plaid API
        /// </summary>
        /// <param name="request">Request object containing desired Plaid parameters.</param>
        /// <returns>Institution information</returns>
        /// <remarks>https://plaid.com/docs/#institutions-by-id</remarks>
        public async Task<GetInstitutionByIdResponse> GetInstitutionById(GetInstitutionByIdRequest request)
        {
            request.DestinationUri = "institutions/get_by_id";
            request.PublicKey = _plaidConfig.PublicKey;
            return await SendRequest<GetInstitutionByIdResponse>(request, _httpClient);
        }

        /// <summary>
        /// Get institutions from the Plaid API based on a "like" query
        /// </summary>
        /// <param name="request">Request object containing desired Plaid parameters.</param>
        /// <returns>List of institutions matching the query.</returns>
        /// <remarks>https://plaid.com/docs/#institution-search</remarks>
        public async Task<SearchInstitutionsResponse> SearchInstitutions(SearchInstitutionsRequest request)
        {
            request.DestinationUri = "institutions/search";
            request.PublicKey = _plaidConfig.PublicKey;
            return await SendRequest<SearchInstitutionsResponse>(request, _httpClient);
        }
    }
}
