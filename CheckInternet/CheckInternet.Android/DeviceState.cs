using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Net;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;

[assembly: Dependency(typeof(CheckInternet.Droid.DeviceState))]
namespace CheckInternet.Droid
{
    public class DeviceState : IDeviceState
    {
        public bool isNetworkReachable()
        {
            bool isNetworkActive;// = false;
            Context context = Forms.Context;//get the current application context

            ConnectivityManager cm = (ConnectivityManager)context.GetSystemService(Context.ConnectivityService);
            NetworkInfo activeConnection = cm.ActiveNetworkInfo;
            isNetworkActive = (activeConnection != null) && activeConnection.IsConnected;

            return isNetworkActive;
        }
    }
}