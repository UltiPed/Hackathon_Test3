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
    public partial class JoinGroup2 : ContentPage
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
        public JoinGroup2()
        {
            InitializeComponent();

            name.Text = "Birthday Party";
            shop.Text = "Mcdonald";
            totalamount.Text = "400";
            memberCount.Text = "5";
            amount.Text = "80";


            ObservableCollection<Members> members = new ObservableCollection<Members>()
            {
                new Members("Alan", 80),
                new Members("Nick", 80),
                new Members("Howard", 80),
                new Members("Ken", 80),
                new Members("Henry", 80)
            };

            listview.ItemsSource = members;

        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            Navigation.RemovePage(this);
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {

        }

        private void btnconfirm_Clicked(object sender, EventArgs e)
        {

        }

        private void btncancel_Clicked(object sender, EventArgs e)
        {

        }
    }
}