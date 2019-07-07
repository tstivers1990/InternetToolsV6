using InternetToolsV6.Networking.Traceroute;
using Prism.Mvvm;

namespace InternetToolsV6.ViewModels
{
    public class TracerouteViewModel : BindableBase
    {
        private readonly ITraceroute _traceroute;

        public TracerouteViewModel(ITraceroute traceroute)
        {
            _traceroute = traceroute;
        }
    }
}