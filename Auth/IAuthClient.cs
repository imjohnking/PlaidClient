using System.Threading.Tasks;

namespace Take5ive.Plaid.Auth
{
    public interface IAuthClient
    {
        public Task<GetAuthResponse> GetAuth(GetAuthRequest request);
    }
}
