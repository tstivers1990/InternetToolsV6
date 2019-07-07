using InternetToolsV6.Networking.PortInspector;
using Prism.Mvvm;

namespace InternetToolsV6.ViewModels
{
    public class PortInspectorViewModel : BindableBase
    {
        private readonly IPortInspector _portInspector;

        public PortInspectorViewModel(IPortInspector portInspector)
        {
            _portInspector = portInspector;
        }
    }
}