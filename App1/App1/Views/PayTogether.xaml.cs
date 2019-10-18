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
    public partial class PayTogether : ContentPage
    {
        public class AClass {
            public string title { get; set; }
            public string host { get; set; }
            public string shop { get; set; }
            public double totalamount { get; set; }
            public double amount { get; set; }

            public AClass(string title, string host, string shop, double totalamount, double amount)
            {
                this.title = title;
                this.host = host;
                this.shop = shop;
                this.totalamount = totalamount;
                this.amount = amount;
            }
        }

        
        public PayTogether()
        {
            InitializeComponent();

            ObservableCollection<AClass> alist = new ObservableCollection<AClass>()
            {
                new AClass("Dinner", "Tom", "Yummy shop", 200.0, 10.0),
                new AClass("Meeting", "Mary", "Good Taste", 500.0, 50.0),
                new AClass("Happy hour", "Owen", "Eat this", 300.0, 30.0)
            };
            alistview.ItemsSource = alist;
            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
        private async void btncreate_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QRCam());
        }
    }
}