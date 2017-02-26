namespace Winther.OWMIntegration
{
    public class OwmEndpoints
    {
        public string GetCurrentWeather { get; private set; }
        public string GetFiveDayForecast { get; private set; }
        public string GetSeveralDaysForecast { get; private set; }

        public OwmEndpoints()
        {
            GetCurrentWeather = "http://api.openweathermap.org/data/2.5/weather?id={0}&appid={1}";
            GetFiveDayForecast = "http://api.openweathermap.org/data/2.5/forecast?id={0}&appid={1}";
            GetSeveralDaysForecast = "http://api.openweathermap.org/data/2.5/forecast/daily?id={0}&cnt={1}&appid={2}";
        }
    }
}
