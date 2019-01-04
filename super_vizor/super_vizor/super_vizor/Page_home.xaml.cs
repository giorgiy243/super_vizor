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
    public partial class Page_home : ContentPage
    {
        private CompanyViewModel _vm;
        private Company _company;

        public Page_home()
        {
            Navigation.PushAsync(new Page_Auth());
            InitializeComponent();
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var vm = BindingContext as CompanyViewModel;
            var company = e.Item as Company;

            _vm = vm;
            _company = company;

            vm.HideOrShowCompany(company);
        }

        private void Button_Remove (object sender, EventArgs e)
        {
            _vm.RemoveCompany(_company);
        }

        private void Button_Details (object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page_Details());
        }

    }

}
