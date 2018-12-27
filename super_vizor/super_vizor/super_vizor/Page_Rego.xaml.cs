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
	public partial class Page_Rego : ContentPage
	{
		public Page_Rego ()
		{
			InitializeComponent ();
		}

        private void Button_CreateProf(object sender, EventArgs e)
        {
            string first_name = FName.Text;
            string last_name = LName.Text;
            int phone_number = Convert.ToInt32(PNumber.Text);
            string email = Email.Text;
            string login = LogIn.Text;
            string password = Passw.Text;

            Navigation.PushAsync(new Page_home());
        }

    }
}