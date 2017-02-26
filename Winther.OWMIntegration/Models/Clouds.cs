using Newtonsoft.Json;

namespace Winther.OWMIntegration.Models
{
    public class Clouds
    {
        [JsonProperty("all")]
        public double Cloudiness { get; set; }
    }
}
