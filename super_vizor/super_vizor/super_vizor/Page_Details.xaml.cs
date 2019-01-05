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
    public partial class Page_Details : ContentPage
    {
        private CompanyViewModel _vm;
        private Groups _goup;
        private Azure _azure;

        internal Page_Details(CompanyViewModel vm)
        {
            InitializeComponent();
            _vm = vm;
        }

        private void ListView_ItemTapped_Groups(object sender, ItemTappedEventArgs e)
        {
            var vm = BindingContext as CompanyViewModel;
            var group = e.Item as Groups;

            _vm = vm;
            _goup = group;

            vm.HideOrShowGroups(group);
        }

        private void ListView_ItemTapped_Azure(object sender, ItemTappedEventArgs e)
        {
            var vm = BindingContext as CompanyViewModel;
            var azure = e.Item as Azure;

            _vm = vm;
            _azure = azure;

            vm.HideOrShowAzure(azure);
        }

        private void Button_Remove_Group(object sender, EventArgs e)
        {
            _vm.RemoveGroup(_goup);
        }

        private void Button_Remove_Azure(object sender, EventArgs e)
        {
            _vm.RemoveAzure(_azure);
        }

        private void Button_Show(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page_Show_Persone_In_Group(_vm));
        }

        private void Button_Groups(object sender, EventArgs e)
        {
            Groups.IsVisible = true;
            Azure.IsVisible = false;
        }

        private void Button_Azure (object sender, EventArgs s)
        {
            Azure.IsVisible = true;
            Groups.IsVisible = false;
        }
    }
}