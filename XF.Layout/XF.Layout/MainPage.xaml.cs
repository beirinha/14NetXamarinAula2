using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF.Layout
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void btnStack(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StackLayout());
        }

        private void btnAbsolute(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AbsolutLayout());
        }

        private void btnRelative(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RelativeLayout());
        }

        private void btnGrid(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GridLayout());
        }

        private void btnFlat(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FlatLayout());
        }

    }
}
