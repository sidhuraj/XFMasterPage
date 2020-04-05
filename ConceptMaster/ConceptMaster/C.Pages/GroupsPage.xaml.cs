using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConceptMaster.C.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GroupsPage : ContentPage
    {
        public GroupsPage()
        {
            InitializeComponent();

            btnGo.Clicked += BtnGo_Clicked;
        }

        private void BtnGo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GroupedPage());
        }
    }
}