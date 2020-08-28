using System.Text.Json.Serialization;

namespace Take5ive.Plaid.Categories
{
    public class Category
    {
        [JsonPropertyName("category_id")]
        public string CategoryID { get; set; }

        public string Group { get; set; }

        public string[] Hierarchy { get; set; }
    }
}
