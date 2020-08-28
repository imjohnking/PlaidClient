using System.Threading.Tasks;

namespace Take5ive.Plaid.Categories
{
    public interface ICategoriesClient
    {
        public Task<GetCategoriesResponse> GetCategories();
    }
}
