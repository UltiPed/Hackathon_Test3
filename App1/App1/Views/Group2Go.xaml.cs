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
    public partial class Group2Go : ContentPage
    {
        public class Members { 
            public String memberName { get; set; }
            public Double indiamount { get; set; }

            public Members(String memberName, Double indiamount)
            {
                this.memberName = memberName;

                this.indiamount = indiamount;
            }
        }
        public Group2Go()
        {
            InitializeComponent();

            name.Text = "Buy Credits";
            shop.Text = "2000fun";
            totalamount.Text = "150";
            memberCount.Text = "4";
            amount.Text = "37.5";


            ObservableCollection<Members> members = new ObservableCollection<Members>()
            {
                new Members("Alan", 37.5),
                new Members("Nick", 37.5),
                new Members("Howard", 37.5),
                new Members("Henry", 37.5)
            };

            listview.ItemsSource = members;

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