using System.Threading.Tasks;
using Winther.OWMIntegration;
using Winther.OWMIntegration.Repositories;

namespace Winther.Gui.Presenters
{
    public class MainWindowPresenter : IWindowPresenter<string>
    {
        private MainWindow _mainWindow;
        private readonly ICityService _cityService;
        private readonly OwmIntegrationService _integrationService;

        public MainWindowPresenter(MainWindow mainWindow, ICityService cityService, 
            OwmIntegrationService integrationService)
        {
            _mainWindow = mainWindow;
            _cityService = cityService;
            _integrationService = integrationService;
        }

        public async Task UpdateAsync(string request)
        {
            var city = await _cityService.GetAsync(request);

            if (city != null)
            {
                var forecast = await _integrationService.GetCurrentWeatherAsync(city.Id);
                _mainWindow.UpdateView(forecast);
            }
        }
    }
}
