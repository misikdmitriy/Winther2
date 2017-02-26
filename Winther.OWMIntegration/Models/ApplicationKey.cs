using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Winther.OWMIntegration.Models
{
    public class ApplicationKey
    {
        public static string AppId { get; }

        static ApplicationKey()
        {
            using (var file = File.OpenText("keys.json"))
            using (var reader = new JsonTextReader(file))
            {
                var jObject = (JObject)JToken.ReadFrom(reader);
                AppId = jObject[nameof(AppId)].ToString();
            }
        }
    }
}
