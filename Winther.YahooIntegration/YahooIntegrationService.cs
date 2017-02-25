using System;
using System.Collections.Specialized;
using System.Net.Http;
using System.Threading.Tasks;
using Winther.Domain;

namespace Winther.YahooIntegration
{
    public class YahooIntegrationService
    {
        private const string AuthEndpoint = "https://api.login.yahoo.com/oauth2/request_auth";
        private const string Endpoint = "https://query.yahooapis.com/v1/public/yql";

        public YahooIntegrationService(string clientId, string clientSecret)
        {
        }

        public async Task<HttpResponseMessage> Send(NameValueCollection queryParams)
        {
            using (var client = new HttpClient())
            {
                var uriBuilder = new UriBuilder(AuthEndpoint)
                {
                    Query = queryParams.ToQueryString()
                };

                var request = new HttpRequestMessage(HttpMethod.Get, AuthEndpoint);

                var response = await client.SendAsync(request);

                return response;
            }
        }
    }
}
