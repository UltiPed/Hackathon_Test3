using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class JoinGroup : ContentPage
    {
        public class Members
        {
            public String memberName { get; set; }
            public Double indiamount { get; set; }

            public Members(String memberName, Double indiamount)
            {
                this.memberName = memberName;

                this.indiamount = indiamount;
            }
        }
        public JoinGroup()
        {
            InitializeComponent();

            name.Text = "Birthday Party";
            shop.Text = "Mcdonald";
            totalamount.Text = "400";
            memberCount.Text = "4";
            amount.Text = "100";


            ObservableCollection<Members> members = new ObservableCollection<Members>()
            {
                new Members("Alan", 100),
                new Members("Nick", 100),
                new Members("Howard", 100),
                new Members("Ken", 100)
            };

            listview.ItemsSource = members;

        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            GoQR.needScan = true;
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {

        }

        private async void btnconfirm_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new JoinGroup2());
            Navigation.RemovePage(this);
        }

        private void btncancel_Clicked(object sender, EventArgs e)
        {

        }
    }
}