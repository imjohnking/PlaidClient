using System.Text.Json.Serialization;

namespace Take5ive.Plaid.AssetReport
{
    public class RemoveAuditCopyRequest : PlaidRequest
    {
        [JsonPropertyName("audit_copy_token")]
        public string AuditCopyToken { get; set; }
    }
}
