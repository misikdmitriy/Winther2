using Newtonsoft.Json;

namespace Winther.OWMIntegration.Models
{
    public class City
    {
        [JsonProperty("_id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("country")]
        public string Country { get; set; }
        [JsonProperty("coord")]
        public Coordinate Coordinate { get; set; }
    }
}
