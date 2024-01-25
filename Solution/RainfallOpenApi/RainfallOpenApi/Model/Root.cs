using System.Text.Json.Serialization;

namespace RainfallOpenApi.Model
{
    public class Root
    {
        [JsonPropertyName("@context")]
        public string context { get; set; }
        public Meta meta { get; set; }
        public List<Item> items { get; set; }
    }
}
