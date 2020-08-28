using System.Text.Json.Serialization;

namespace Take5ive.Plaid.Accounts
{
    /// <summary>
    /// Account balance information
    /// </summary>
    public class Balances
    {
        /// <summary>
        /// The amount of funds available to be withdrawn from the account, as determined by the financial institution
        /// </summary>
        public int? Available { get; set; }

        /// <summary>
        /// The total amount of funds in or owed by the account
        /// </summary>
        public float Current { get; set; }

        /// <summary>
        /// The ISO currency code of the balance
        /// </summary>
        [JsonPropertyName("iso_currency_code")]
        public string ISOCurrencyCode { get; set; }

        /// <summary>
        /// For credit-type accounts, this represents the credit limit
        /// </summary>
        public int? Limit { get; set; }

        /// <summary>
        /// The unofficial currency code associated with the balance
        /// </summary>
        [JsonPropertyName("unofficial_currency_code")]
        public object UnofficialCurrencyCode { get; set; }
    }
}
