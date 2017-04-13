using System;
using System.Windows;
using Winther.OWMIntegration.Models;

namespace Winther.Gui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnClosed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

        public void UpdateView(OneDayForecastDto forecast)
        {
            throw new NotImplementedException();
        }
    }
}
