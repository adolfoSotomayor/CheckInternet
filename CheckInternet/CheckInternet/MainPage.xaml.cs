using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CheckInternet
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        public void clickedButton(Object sender, EventArgs e)
        {
            bool internetActive = DependencyService.Get<IDeviceState>().isNetworkReachable();
            this.DisplayAlert("Device Network", internetActive.ToString(), "OK");
        }

    }
}
