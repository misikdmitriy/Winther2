using System;

using Newtonsoft.Json;

using Winther.Domain.Converters;

namespace Winther.OWMIntegration.Models
{
    public class City
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("country")]
        public string Country { get; set; }
        [JsonProperty("coord")]
        public Coordinate Coordinate { get; set; }
        [JsonProperty("sunrise")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Sunrise { get; set; }
        [JsonProperty("sunset")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Sunset { get; set; }
    }
}
