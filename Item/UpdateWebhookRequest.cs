using System.Text.Json.Serialization;

namespace Take5ive.Plaid.Item
{
    public class UpdateWebhookRequest : PlaidRequest
    {
        public string Webhook { get; set; }
    }
}
