namespace Take5ive.Plaid.Item
{
    public class GetItemResponse : PlaidResponse
    {
        public PlaidItem Item { get; set; }

        public Status Status { get; set; }
    }
}
