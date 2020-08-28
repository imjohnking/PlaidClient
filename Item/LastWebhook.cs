using System;
using System.Text.Json.Serialization;

namespace Take5ive.Plaid.Item
{
    public class LastWebhook
    {
        [JsonPropertyName("code_sent")]
        public string CodeSent { get; set; }

        [JsonPropertyName("sent_at")]
        public DateTime SentAt { get; set; }
    }
}
