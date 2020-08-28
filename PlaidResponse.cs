using System;
using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Take5ive.Plaid
{
    public class PlaidResponse
    {
        private readonly JsonSerializerOptions _jsonOptions;

        public PlaidResponse()
        {
            _jsonOptions = new JsonSerializerOptions() {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };
        }

        [JsonPropertyName("request_id")]
        public string RequestID { get; set; }

        [JsonPropertyName("status_code")]
        public HttpStatusCode StatusCode { get; set; }

        public PlaidError ErrorDetails { get; set; }

        public string Serialize(bool ignoreNullValues = true)
        {
            _jsonOptions.IgnoreNullValues = ignoreNullValues;

            return JsonSerializer.Serialize<Object>(this, _jsonOptions);
        }
    }
}
