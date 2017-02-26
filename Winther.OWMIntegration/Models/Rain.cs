using Newtonsoft.Json;

namespace Winther.OWMIntegration.Models
{
    public class Rain
    {
        [JsonProperty("3h")]
        public double RainVolume { get; set; }
    }
}
