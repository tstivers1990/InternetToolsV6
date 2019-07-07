using CommonServiceLocator;
using InternetToolsV6.ViewModels;
using InternetToolsV6.Views;
using Prism.DryIoc;
using Prism.Ioc;
using System.Windows;
using InternetToolsV6.Networking.Ping;
using InternetToolsV6.Networking.PortInspector;
using InternetToolsV6.Networking.Traceroute;

namespace InternetToolsV6
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // Register Views/ViewModels
            containerRegistry.RegisterForNavigation<MainView, MainViewModel>();
            containerRegistry.RegisterForNavigation<PingView, PingViewModel>();
            containerRegistry.RegisterForNavigation<PortInspectorView, PortInspectorViewModel>();
            containerRegistry.RegisterForNavigation<TracerouteView, TracerouteViewModel>();

            // Register services
            containerRegistry.RegisterSingleton<IPing, Ping>();
            containerRegistry.RegisterSingleton<IPortInspector, PortInspector>();
            containerRegistry.RegisterSingleton<ITraceroute, Traceroute>();
        }

        protected override Window CreateShell()
        {
            // Start the app with MainView
            return ServiceLocator.Current.GetInstance<MainView>();
        }
    }
}
