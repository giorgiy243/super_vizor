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
	public partial class Page_Show_Persone_In_Group : ContentPage
	{
        private CompanyViewModel _vm;
        private Persones _persone;

        internal Page_Show_Persone_In_Group (CompanyViewModel vm)
		{
			InitializeComponent ();
            _vm = vm;
		}

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var vm = BindingContext as CompanyViewModel;
            var person = e.Item as Persones;

            _vm = vm;
            _persone = person;

            vm.HideOrShowPersones(person);
        }

        private void Button_Remove(object sender, EventArgs e)
        {
            _vm.RemovePersone(_persone);
        }

        private void Button_Update(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page_Update_Persone(_vm, _persone));
        }

        private void Button_Add(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page_Add_Persone(_vm));
        }
    }
}