using System.Threading.Tasks;

namespace Take5ive.Plaid.Transactions
{
    public interface ITransactionsClient
    {
        public Task<GetTransactionsResponse> GetTransactions(GetTransactionsRequest request);

        public Task<PlaidResponse> RefreshTransactions(string accessToken);
    }
}
