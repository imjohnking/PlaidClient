using System.Threading.Tasks;

namespace Take5ive.Plaid.Income
{
    public interface IIncomeClient
    {
        public Task<GetIncomeResponse> GetIncome(string accessToken);
    }
}
