using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Take5ive.Plaid.Item
{
    public class Status
    {
        [JsonPropertyName("last_webhook")]
        public LastWebhook LastWebhook { get; set; }
    }
}
