using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using Winther.OWMIntegration.Models;
using Winther.OWMIntegration.Parsers;

namespace Winther.OWMIntegration.Repositories
{
    public class CityRepository
    {
        private IList<City> CitiesCache { get; }

        public CityRepository()
        {
            CitiesCache = new List<City>();
        }

        public async Task<City> GetAsync(int id)
        {
            return await GetAsync(city => city.Id == id);
        }

        public async Task<City> GetAsync(string name)
        {
            return await GetAsync(city => city.Name == name || city.Country == name);
        }

        public async Task<City> GetAsync(Func<City, bool> condition)
        {
            var result = CitiesCache.FirstOrDefault(condition);

            if (result != null)
            {
                return result;
            }

            using (var file = File.OpenText("city.list.json"))
            {
                await file.ReadLineAsync(); // ignore first line

                while (!file.EndOfStream)
                {
                    var line = await file.ReadLineAsync();
                    var city = CityParser.Parse(line);

                    if (condition(city))
                    {
                        CitiesCache.Add(city);
                        return city;
                    }
                }
            }

            return null;
        }

        public void ClearCache()
        {
            CitiesCache.Clear();
        }
    }
}
