using System.Collections.Specialized;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Winther.YahooIntegration;

namespace Winther.Gui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string clientId, clientSecret;

            using (var file = File.OpenText("keys.json"))
            using (var reader = new JsonTextReader(file))
            {
                var jObject = (JObject)JToken.ReadFrom(reader);
                clientId = jObject[nameof(clientId)].ToString();
                clientSecret = jObject[nameof(clientSecret)].ToString();
            }
            var yahooIntegrationService = new YahooIntegrationService(clientId, clientSecret);
            var @params = new NameValueCollection
            {
                { "client_id", clientId },
                { "redirect_uri", "oob" },
                { "response_type", "code" },
            };
            var task = Task.Run(async() => await yahooIntegrationService.Send(@params));

            var result = task.Result;
            var str = result.Content.ReadAsStringAsync().Result;
        }
    }
}
