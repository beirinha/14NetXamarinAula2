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
    public partial class GridLayout : ContentPage
    {
        private StringBuilder _texto = new StringBuilder();

        public GridLayout()
        {
            InitializeComponent();
        }

        private void btnVoltar(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btnLocal = (Button)sender;

            if (!btnLocal.Text.ToUpper().Equals("C"))
                _texto.Append(btnLocal.Text);
            else
                _texto.Clear();

            txtConta.Text = _texto.ToString();
        }

        private void btnComputar(object sender, EventArgs e)
        {
            int posicao = txtConta.Text.IndexOf("+");
            int n1 = Convert.ToInt32(txtConta.Text.Substring(0, posicao));
            int n2 = Convert.ToInt32(txtConta.Text.Substring(posicao, txtConta.Text.Length - posicao));

            int result = n1 + n2;

            txtConta.Text = result.ToString();

        }
    }
}