using Newtonsoft.Json;
using Winther.OWMIntegration.Models;

namespace Winther.OWMIntegration.Parsers
{
    public class CityParser
    {
        public static City Parse(string line)
        {
            return JsonConvert.DeserializeObject<City>(line);
        }
    }
}
