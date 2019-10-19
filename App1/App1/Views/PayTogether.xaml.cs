using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing.Net.Mobile.Forms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1.Data;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PayTogether : ContentPage
    {
        ZXingScannerPage scannerPage;

        public class AClass
        {
            public string title { get; set; }
            public string host { get; set; }
            public string shop { get; set; }
            public double totalamount { get; set; }
            public double amount { get; set; }
            public Boolean isMember { get; set; }
            public Boolean isHost { get; set; }

            public AClass(string title, string host, string shop, double totalamount, double amount, Boolean isMember, Boolean isHost)
            {
                this.title = title;
                this.host = host;
                this.shop = shop;
                this.totalamount = totalamount;
                this.amount = amount;
                this.isMember = isMember;
                this.isHost = isHost;
            }
        }



        public PayTogether() : base()
        {
            InitializeComponent();

            ObservableCollection<AClass> alist = new ObservableCollection<AClass>()
            {
                new AClass("Booking", "Tom", "Yummy shop", 200.0, 10.0, true, false),
                new AClass("Computer society activity", "Mary", "Good Taste", 500.0, 50.0, false, true),
                new AClass("Happy hour", "Owen", "Eat this", 300.0, 30.0, true, false),
                new AClass("Buy Credits", "Owen", "2000fun", 150, 37.5, true, false)
            };
            alistview.ItemsSource = alist;
            
        }        

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
        private async void btncreate_Clicked(object sender, EventArgs e)
        {
           
                scannerPage = new ZXingScannerPage();
            scannerPage.OnScanResult += (result) =>
            {
                scannerPage.IsScanning = false;

                Device.BeginInvokeOnMainThread(() =>
                {
                    Navigation.PopAsync();
                    DisplayAlert("Scanned Barcode", result.Text, "Success");
                });
            };

            await Navigation.PushAsync(scannerPage);
        }

        private async void alistview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new Group2Go());
        }
    }
}