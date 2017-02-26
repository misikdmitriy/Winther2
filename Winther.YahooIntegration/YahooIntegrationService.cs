using System;
using System.Collections.Specialized;
using System.Net.Http;
using System.Threading.Tasks;
using Winther.Domain;

namespace Winther.YahooIntegration
{
    public class YahooIntegrationService
    {
        private const string AuthUrl = "https://api.login.yahoo.com/oauth2/get_token";
        private const string Endpoint = "https://query.yahooapis.com/v1/public/yql";

        public YahooIntegrationService()
        {
        }

        public async Task<HttpResponseMessage> Send(NameValueCollection queryParams)
        {
            return await SendRequest(queryParams, HttpMethod.Get, Endpoint);
        }

        public async Task<HttpResponseMessage> GetAuthUrl(NameValueCollection queryParams)
        {
            return await SendRequest(queryParams, HttpMethod.Post, AuthUrl);
        }

        private async Task<HttpResponseMessage> SendRequest(NameValueCollection queryParams, HttpMethod httpMethod, string uri)
        {
            using (var client = new HttpClient())
            {
                var uriBuilder = new UriBuilder(uri)
                {
                    Query = queryParams.ToQueryString()
                };

                var request = new HttpRequestMessage(httpMethod, uriBuilder.Uri);

                var response = await client.SendAsync(request);

                return response;
            }
        }
    }
}
