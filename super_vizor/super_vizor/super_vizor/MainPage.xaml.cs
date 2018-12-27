using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace super_vizor
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Page_Auth(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page_Auth());
        }
    }
}
