using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Winther.OWMIntegration.Models;

namespace Winther.OWMIntegration
{
    public class OwmIntegrationService
    {
        private readonly string _appId;
        private OwmEndpoints Endpoints { get; }

        public OwmIntegrationService(OwmEndpoints endpoints, string appId)
        {
            Endpoints = endpoints;
            _appId = appId;
        }

        public async Task<OneForecastDto> GetCurrentWeatherAsync(int cityId)
        {
            var uri = string.Format(Endpoints.GetCurrentWeather, cityId, _appId);
            var response = await SendRequest(HttpMethod.Get, uri);
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<OneForecastDto>(content);
        }

        private async Task<HttpResponseMessage> SendRequest(HttpMethod httpMethod, string uri)
        {
            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage(httpMethod, uri);

                var response = await client.SendAsync(request);

                return response;
            }
        }
    }
}
