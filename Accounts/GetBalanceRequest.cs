using System.Text.Json.Serialization;

namespace Take5ive.Plaid.Accounts
{
    /// <summary>
    /// Used in retrieving real-time balances for an account
    /// </summary>
    public class GetBalanceRequest : PlaidRequest
    {
        /// <summary>
        /// Request constructor
        /// </summary>
        public GetBalanceRequest()
        {
            Options = new RequestOptions();
        }

        /// <summary>
        /// Optional request data
        /// </summary>
        public RequestOptions Options { get; set; }

        /// <summary>
        /// Optional request data
        /// </summary>
        public class RequestOptions
        {
            /// <summary>
            /// A list of account_ids to retrieve for the Item
            /// </summary>
            [JsonPropertyName("account_ids")]
            public string[] AccountIDs { get; set; }
        }

    }
}
