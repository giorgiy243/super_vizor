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
        private Groups _group;

        public Page_Details ()
		{
			InitializeComponent ();
		}

        private void Button_Groups (object sender, EventArgs e)
        {
            lvGroups.IsVisible = !lvGroups.IsVisible;
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var vm = BindingContext as CompanyViewModel;
            var group = e.Item as Groups;

            _vm = vm;
            _group = group;

            vm.HideOrShowGroups(group);
        }

        private void Button_Remove_Group (object sender, EventArgs e)
        {
            _vm.RemoveGroup(_group);
        }

        private void Button_Show_Group (object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page_Show_Persone_In_Group());
        }

    }
}