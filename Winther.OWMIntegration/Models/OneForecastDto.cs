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
    }
}
