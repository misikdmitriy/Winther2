using System.IO;
using System.Threading.Tasks;
using System.Windows;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using Winther.Domain;
using Winther.OWMIntegration;
using Winther.OWMIntegration.Repositories;

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

            string appId;

            using (var file = File.OpenText("keys.json"))
            using (var reader = new JsonTextReader(file))
            {
                var jObject = (JObject)JToken.ReadFrom(reader);
                appId = jObject[nameof(appId)].ToString();
            }

            var repo = new CityRepository();
            var city = Task.Run(async () => await repo.GetAsync("London")).Result;

            var service = new OwmIntegrationService(new OwmEndpoints(), appId);
            var weatherResponse = Task.Run(async() => await service.GetCurrentWeatherAsync(city.Id));

            var result = weatherResponse.Result;
        }
    }
}
