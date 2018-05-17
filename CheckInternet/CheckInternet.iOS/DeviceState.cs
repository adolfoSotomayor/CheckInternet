using UIKit;
using NetworkExtension;
using Foundation;
using Xamarin.Forms;

[assembly: Dependency(typeof(CheckInternet.iOS.DeviceState))]
namespace CheckInternet.iOS
{
    public class DeviceState : IDeviceState
    {
        public DeviceState()
        {
        }

        public bool isNetworkReachable()
        {
            bool hasInternet = true;
            NetworkStatus internetStatus = Reachability.InternetConnectionStatus();

            if (internetStatus == NetworkStatus.NotReachable)
            {
                hasInternet = false;

            }
            return hasInternet;
        }
    }
}