using System.Text.Json.Serialization;

namespace RainfallOpenApi.Model
{
    public class FloodArea
    {
        [JsonPropertyName("@id")]
        public string id { get; set; }
        public string county { get; set; }
        public string notation { get; set; }
        public string polygon { get; set; }
        public string riverOrSea { get; set; }
    }
}
