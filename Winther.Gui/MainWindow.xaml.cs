using System.Threading.Tasks;
using System.Windows;

using Winther.OWMIntegration;
using Winther.OWMIntegration.Models;
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

            var repo = new CityRepository();
            var city = Task.Run(async () => await repo.GetAsync("London")).Result;

            var service = new OwmIntegrationService(new OwmEndpoints(), ApplicationKey.AppId);
            var weatherResponse = Task.Run(async() => await service.GetCurrentWeatherAsync(city.Id));

            var result = weatherResponse.Result;
        }
    }
}
