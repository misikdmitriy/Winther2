using System;
using System.Threading.Tasks;

using Winther.OWMIntegration.Models;

namespace Winther.OWMIntegration.Repositories
{
    public interface ICityService
    {
        void ClearCache();
        Task<City> GetAsync(Func<City, bool> condition);
        Task<City> GetAsync(int id);
        Task<City> GetAsync(string name);
    }
}