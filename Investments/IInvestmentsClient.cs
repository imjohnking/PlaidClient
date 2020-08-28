using System.Threading.Tasks;

namespace Take5ive.Plaid.Investments
{
    public interface IInvestmentsClient
    {
        public Task<GetHoldingsResponse> GetHoldings(GetHoldingsRequest request);

        public Task<GetTransactionsResponse> GetTransactions(GetTransactionsRequest request);
    }
}
