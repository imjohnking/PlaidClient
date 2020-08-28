using System.Threading.Tasks;

namespace Take5ive.Plaid.Item
{
    public interface IItemClient
    {
        public Task<ExchangePublicTokenResponse> ExchangePublicToken(ExchangePublicTokenRequest request);

        public Task<GetPublicTokenResponse> GetPublicToken(string accessToken);

        public Task<UpdateWebhookResponse> UpdateWebhook(UpdateWebhookRequest request);

        public Task<GetItemResponse> GetItem(string accessToken);

        public Task<RotateAccessTokenResponse> RotateAccessToken(string accessToken);

        public Task<RemoveItemResponse> RemoveItem(string accessToken);
    }
}
