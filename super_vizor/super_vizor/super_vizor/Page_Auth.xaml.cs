using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace super_vizor
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page_Auth : ContentPage
	{
		public Page_Auth ()
		{
			InitializeComponent ();
		}

        private void buttonEnter_click(object sender, EventArgs e)
        {
            // проверка на регистрацию
            Navigation.PopAsync();
        }

        private void buttonRegistration_click(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page_Rego());
        }

    }
}