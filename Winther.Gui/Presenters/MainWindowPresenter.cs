using System.Threading.Tasks;
using Winther.OWMIntegration;
using Winther.OWMIntegration.Models;
using Winther.OWMIntegration.Repositories;

namespace Winther.Gui.Presenters
{
    public class MainWindowPresenter : IWindowPresenter<OneDayForecastDto>
    {
        private MainWindow _mainWindow;

        public MainWindowPresenter(MainWindow mainWindow)
        {
            _mainWindow = mainWindow;
        }

        public async Task UpdateAsync(OneDayForecastDto forecast)
        {

        }
    }
}
