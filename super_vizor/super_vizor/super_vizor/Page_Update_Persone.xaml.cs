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
	 partial class Page_Update_Persone : ContentPage
	{
        private Persones _persone = new Persones();
        private CompanyViewModel _vm;
        private Persones _oldPersone;

        internal Page_Update_Persone(CompanyViewModel vm, Persones pers)
        {
            InitializeComponent();
            _vm = vm;
            _oldPersone = pers;
            GetPlaseholder();
        }

         private void GetPlaseholder()
        {
            FName.Placeholder = _oldPersone.FirstName;
            LName.Placeholder = _oldPersone.LastName;
            Age.Placeholder = Convert.ToString(_oldPersone.Age);
            Experience.Placeholder = Convert.ToString(_oldPersone.Experience);
            Salary.Placeholder = Convert.ToString(_oldPersone.Salary);
            Position.Placeholder = _oldPersone.Position;
        }
        private void Button_Save(object sender, EventArgs e)
        {
            if (FName.Text == null)
            {
                _persone.FirstName = FName.Placeholder;
            }
            else
            {
            _persone.FirstName = FName.Text;
            }
            if (LName.Text == null)
            {
                _persone.LastName = LName.Placeholder;
            }
            else
            {
            _persone.LastName = LName.Text;
            }
            if (Age.Text == null)
            {
                _persone.Age = Convert.ToInt32(Age.Placeholder);
            }
            else
            {
            _persone.Age = Convert.ToInt32(Age.Text);
            }
            if (Experience.Text == null)
            {
                _persone.Experience = Convert.ToInt32(Experience.Placeholder);
            }
            else
            {
            _persone.Experience = Convert.ToInt32(Experience.Text);
            }
            if (Salary.Text == null)
            {
                _persone.Salary = Convert.ToInt32(Salary.Placeholder);
            }
            else
            {
            _persone.Salary = Convert.ToInt32(Salary.Text);
            }
            if (Position.Text == null)
            {
                _persone.Position = Position.Placeholder;
            }
            else
            {
            _persone.Position = Position.Text;
            }

            _vm.ChangePerson(_oldPersone, _persone);
            Navigation.PopAsync();
        }
	}
}