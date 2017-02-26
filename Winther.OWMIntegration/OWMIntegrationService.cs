using System.Net.Http;
using System.Threading.Tasks;

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

        public async Task<HttpResponseMessage> GetCurrentWeatherAsync(int cityId)
        {
            var uri = string.Format(Endpoints.GetCurrentWeather, cityId, _appId);
            return await SendRequest(HttpMethod.Get, uri);
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
