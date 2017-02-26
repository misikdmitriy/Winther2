using Newtonsoft.Json;

namespace Winther.OWMIntegration.Models
{
    public class Snow
    {
        [JsonProperty("3h")]
        public double SnowLevel { get; set; }
    }
}
