using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF.Layout
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AbsolutLayout : ContentPage
	{
		public AbsolutLayout ()
		{
			InitializeComponent ();
		}

        private void btnVoltar(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
	}
}