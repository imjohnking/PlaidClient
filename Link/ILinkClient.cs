using System.Threading.Tasks;

namespace Take5ive.Plaid.Link
{
    public interface ILinkClient
    {
        public Task<GetLinkTokenResponse> GetLinkToken(GetLinkTokenRequest request);
    }
}
