namespace Take5ive.Plaid.Categories
{
    public class GetCategoriesRequest : PlaidRequest
    {
        public GetCategoriesRequest()
        {
            this.Authenticate = false;
        }
    }
}
