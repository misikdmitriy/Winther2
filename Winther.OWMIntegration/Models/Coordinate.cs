using Newtonsoft.Json;

namespace Winther.OWMIntegration.Models
{
    public class Coordinate
    {
        [JsonProperty("lon")]
        public double Longitude { get; set; }
        [JsonProperty("lat")]
        public double Latitude { get; set; }
    }
}
