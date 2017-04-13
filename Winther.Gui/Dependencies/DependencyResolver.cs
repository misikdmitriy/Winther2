using Autofac;
using Winther.Gui.Presenters;
using Winther.OWMIntegration;
using Winther.OWMIntegration.Models;
using Winther.OWMIntegration.Repositories;

namespace Winther.Gui.Dependencies
{
    public class DependencyResolver
    {
        public static IContainer Container { get; private set; }
        private static ContainerBuilder Builder { get; }

        static DependencyResolver()
        {
            Builder = new ContainerBuilder();
            Build();
        }

        protected DependencyResolver()
        { }

        private static void Build()
        {
            Builder.RegisterType<OwmEndpoints>()
                .AsSelf();

            Builder.RegisterInstance(new OwmApplicationKey())
                .AsSelf();

            Builder.RegisterType<CityService>()
                .As<ICityService>();

            Builder.RegisterType<OwmIntegrationService>()
                .AsSelf()
                .WithParameter("appId", OwmApplicationKey.AppId);

            Builder.RegisterType<MainWindow>()
                .AsSelf();

            Builder.RegisterType<MainWindowPresenter>()
                .As<IWindowPresenter<OneDayForecastDto>>();

            Container = Builder.Build();
        }
    }
}
