using System.Threading.Tasks;

namespace Take5ive.Plaid.Institutions
{
    public interface IInstitutionsClient
    {
        public Task<GetInstitutionsResponse> GetInstitutions(GetInstitutionsRequest request);
        public Task<GetInstitutionByIdResponse> GetInstitutionById(GetInstitutionByIdRequest request);
        public Task<SearchInstitutionsResponse> SearchInstitutions(SearchInstitutionsRequest request);
    }
}
