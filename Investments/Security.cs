using System.Text.Json.Serialization;

namespace Take5ive.Plaid.Investments
{
    public class Security
    {
        [JsonPropertyName("close_price")]
        public float ClosePrice { get; set; }

        [JsonPropertyName("close_price_as_of")]
        public object ClosePriceAsOf { get; set; }
        
        public string Cusip { get; set; }

        [JsonPropertyName("institution_id")]
        public string InstitutionID { get; set; }
        
        [JsonPropertyName("institution_security_id")]
        public string InstitutionSecurityID { get; set; }
        
        [JsonPropertyName("is_cash_equivalent")]
        public bool IsCashEquivalent { get; set; }
        
        public string Isin { get; set; }

        [JsonPropertyName("iso_currency_code")]
        public string ISOCurrencyCode { get; set; }
        
        public string Name { get; set; }

        [JsonPropertyName("proxy_security_id")]
        public object ProxySecurityID { get; set; }

        [JsonPropertyName("security_id")]
        public string SecurityID { get; set; }

        public object Sedol { get; set; }
        
        [JsonPropertyName("ticker_symbol")]
        public string TickerSymbol { get; set; }
        
        public string Type { get; set; }
        
        [JsonPropertyName("unofficial_currency_code")]
        public object UnofficialCurrencyCode { get; set; }
    }
}
