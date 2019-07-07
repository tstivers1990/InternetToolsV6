using InternetToolsV6.Networking.Ping;
using Prism.Mvvm;

namespace InternetToolsV6.ViewModels
{
    public class PingViewModel : BindableBase
    {
        private readonly IPing _ping;

        public PingViewModel(IPing ping)
        {
            _ping = ping;
        }
    }
}