using System.Text.Json.Serialization;

namespace Take5ive.Plaid.Accounts
{
    /// <summary>
    /// Account ACH Information
    /// </summary>
    public class ACHInfo
    {
        /// <summary>
        /// The ACH account number for the account
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// The Plaid account ID associated with the account numbers
        /// </summary>
        [JsonPropertyName("account_id")]
        public string AccountID { get; set; }

        /// <summary>
        /// The ACH routing number for the account
        /// </summary>
        public string Routing { get; set; }

        /// <summary>
        /// The ACH wire routing number for the account, if available
        /// </summary>
        [JsonPropertyName("wire_routing")]
        public string WireRouting { get; set; }
    }
}
