using Newtonsoft.Json;

namespace Winther.OWMIntegration.Models
{
    public class Weather
    {
        [JsonProperty("temp")]
        public double Temperature { get; set; }
        [JsonProperty("pressure")]
        public double Pressure { get; set; }
        [JsonProperty("sea_level")]
        public double SeaLevelPressure { get; set; }
        [JsonProperty("grnd_level")]
        public double GroundLevelPressure { get; set; }
        [JsonProperty("humidity")]
        public double Humidity { get; set; }
        [JsonProperty("temp_min")]
        public double TemperatureMin { get; set; }
        [JsonProperty("temp_max")]
        public double TemperatureMax { get; set; }
    }
}