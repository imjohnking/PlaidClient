using System.Text.Json.Serialization;
using Take5ive.Plaid.Identity;

namespace Take5ive.Plaid.Accounts
{
    /// <summary>
    /// Linked Bank Account
    /// </summary>
    public class Account
    {
        /// <summary>
        /// Gets or sets the Account ID
        /// </summary>
        /// <value>The unique ID of the account</value>
        [JsonPropertyName("account_id")]
        public string AccountID { get; set; }

        /// <summary>
        /// Gets or sets the account balances object
        /// </summary>
        /// <value>Account balance details</value>
        public Balances Balances { get; set; }

        /// <summary>
        /// Gets or sets the account mask
        /// </summary>
        /// <value>The last 2-4 alphanumeric characters of an account's official account number</value>
        public string Mask { get; set; }

        /// <summary>
        /// Gets or sets the account name
        /// </summary>
        /// <value>The name of the Account, either assigned by the user or the financial institution itself</value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the official account name
        /// </summary>
        /// <value>The official name of the Account as given by the financial institution</value>
        [JsonPropertyName("official_name")]
        public string OfficialName { get; set; }

        /// <summary>
        /// Gets or sets the account owner object
        /// </summary>
        /// <value>Account owner details</value>
        public Owner[] Owners { get; set; }

        /// <summary>
        /// Gets or sets the account subtype
        /// </summary>
        /// <value>Account subtype</value>
        /// <remarks>https://plaid.com/docs/#account-subtypes</remarks>
        public string Subtype { get; set; }

        /// <summary>
        /// Gets or sets the account type
        /// </summary>
        /// <value>Account type</value>
        /// <remarks>https://plaid.com/docs/#account-types</remarks>
        public string Type { get; set; }
    }
}
