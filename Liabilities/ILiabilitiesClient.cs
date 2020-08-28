using System.Threading.Tasks;

namespace Take5ive.Plaid.Liabilities
{
    public interface ILiabilitiesClient
    {
        public Task<GetLiabilitiesResponse> GetLiabilities(GetLiabilitiesRequest request);
    }
}
