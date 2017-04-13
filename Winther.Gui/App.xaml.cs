using System.Windows;
using Autofac;
using Winther.Gui.Dependencies;

namespace Winther.Gui
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var mainWindow = DependencyResolver.Container.Resolve<MainWindow>();
            mainWindow.Show();
        }
    }
}
