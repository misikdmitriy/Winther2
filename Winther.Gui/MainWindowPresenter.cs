using System.Threading.Tasks;

using Winther.OWMIntegration;
using Winther.OWMIntegration.Models;
using Winther.OWMIntegration.Repositories;

namespace Winther.Gui
{
    public class MainWindowPresenter
    {
        private readonly CityRepository _cityRepository;
        private readonly OwmIntegrationService _integrationService;

        public MainWindowPresenter(CityRepository cityRepository, OwmIntegrationService integrationService)
        {
            _cityRepository = cityRepository;
            _integrationService = integrationService;
        }

        public async Task<OneDayForecastDto> GetForecast()
        {
            var city = await _cityRepository.GetAsync("London");
            
            var weatherResponse = await _integrationService.GetCurrentWeatherAsync(city.Id);

            return weatherResponse;
        }
    }
}
