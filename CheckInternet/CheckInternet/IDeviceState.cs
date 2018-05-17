using System;
using System.Collections.Generic;
using System.Text;

namespace CheckInternet
{
    public interface IDeviceState
    {

        bool isNetworkReachable();
    }
}
