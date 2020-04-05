using ConceptMaster.Call;
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
    public partial class GroupedPage : MasterDetailPage
    {
        public GroupedPage()
        {
            InitializeComponent();
            GroupedDate();
            NavigationPage.SetHasNavigationBar(this, false);
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(TotalIndians)));
        }


        private void GroupedDate()
        {
            List<GroupesClassE> objGRO = new List<GroupesClassE>();

            objGRO.Add(new GroupesClassE { IconGroup = "India.jpg", GroupNames = "Indians", TargetType = typeof(TotalIndians) });

            objGRO.Add(new GroupesClassE { IconGroup = "austrilia.jpg", GroupNames = "Austrilia", TargetType = typeof(TotalAustriala) });

            objGRO.Add(new GroupesClassE { IconGroup = "austrilia.jpg", GroupNames = "canada", TargetType = typeof(TotalCanada) });


            objGRO.Add(new GroupesClassE { IconGroup = "southafrica.jpg", GroupNames = "south Africa", TargetType = typeof(TotalSouthafrica) });

            listtarget.ItemsSource = objGRO;

            listtarget.ItemSelected += Listtarget_ItemSelected;

        }

        private void Listtarget_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as GroupesClassE;

            Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
            IsPresented = false;   //if u write this command is false then only going to clicked page//
        }
    }
}