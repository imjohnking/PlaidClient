using System.Threading.Tasks;

namespace Take5ive.Plaid.Identity
{
    public interface IIdentityClient
    {
        public Task<GetIdentityResponse> GetIdentity(string accessToken);
    }
}
