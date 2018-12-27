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
        public Page_home()
        {
            InitializeComponent();
            ShowFirms();
            

        }

        private void ShowFirms()
        {
            var image = new Image { Source = "cat.jpg" };
            this.Content = image;

            List<string> mItem = new List<string>();
            ListView mListVirv = new ListView();
            mListVirv.ItemsSource = mItem;
            Company[] com = new Company [5];
            {
                com[0] = new Company("Akvelon");
                com[1] = new Company("Microsoft");
                com[2] = new Company("Google");
                com[3] = new Company("Space");
                com[4] = new Company("EA");
            }

            foreach (var item in com)
            {
                mItem.Add(item.ShowComp());
            }
            this.Content =  mListVirv;
        }
    }
}