using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Take5ive.Json.Converters;

namespace Take5ive.Plaid
{
    /// <summary>
    /// Base class for all requests to the API
    /// </summary>
    public class PlaidRequest
    {
        private readonly JsonSerializerOptions _jsonOptions;

        /// <summary>
        /// Constructor for base class
        /// </summary>
        public PlaidRequest()
        {
            _jsonOptions = new JsonSerializerOptions() {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };
        }

        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }

        [JsonPropertyName("client_id")]
        internal string ClientID { get; set; }

        [JsonPropertyName("secret")]
        internal string Secret { get; set; }

        [JsonPropertyName("public_key")]
        internal string PublicKey { get; set; }

        internal string DestinationUri { get; set; }

        internal bool Authenticate { get; set; } = true;

        /// <summary>
        /// Serialize this object to JSON.
        /// </summary>
        /// <param name="ignoreNullValues">Do you want to ignore null values when creating the JSON?</param>
        /// <returns>JSON String</returns>
        internal string Serialize(bool ignoreNullValues = true)
        {
            _jsonOptions.IgnoreNullValues = ignoreNullValues;

            _jsonOptions.Converters.Add(new Newtonizer(this.GetType()));

            return JsonSerializer.Serialize<Object>(this, _jsonOptions);
        }
    }
}
