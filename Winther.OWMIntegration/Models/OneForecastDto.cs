using Newtonsoft.Json;

namespace Winther.OWMIntegration.Models
{
    public class OneForecastDto
    {
        [JsonProperty("main")]
        public Weather Weather { get; set; }
        [JsonProperty("visibility")]
        public int Visibility { get; set; }
        [JsonProperty("wind")]
        public Wind Wind { get; set; }
        [JsonProperty("snow")]
        public Snow Snow { get; set; }
        [JsonProperty("rain")]
        public Rain Rain { get; set; }
        [JsonProperty("clouds")]
        public Clouds Clouds { get; set; }
        [JsonProperty("sys")]
        public City City { get; set; }
    }
}
