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
	public partial class Page_Add_Persone : ContentPage
	{
        private CompanyViewModel _vm;

        internal Page_Add_Persone (CompanyViewModel vm)
		{
			InitializeComponent ();
            _vm = vm;
		}

        private void Button_Save(object sender, EventArgs s)
        {
            Persones person = new Persones();

            person.Age = Convert.ToInt32(Age.Text);
            person.Experience = Convert.ToInt32(Experience.Text);
            person.FirstName = FName.Text;
            person.IsVisible = false;
            person.LastName = LName.Text;
            person.Position = Position.Text;
            person.Salary = Convert.ToInt32(Salary.Text);

            _vm.AddPersone(person);

            Navigation.PopAsync();
        }

    }
}