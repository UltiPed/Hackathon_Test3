using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GoQR : ContentPage
    {
        ZXingScannerPage scannerPage;
        public static Boolean needScan = true;
        public GoQR()
        {
            InitializeComponent();

        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            if (needScan)
            {
                scannerPage = new ZXingScannerPage();
                scannerPage.OnScanResult += (result) =>
                {
                    scannerPage.IsScanning = false;

                    Device.BeginInvokeOnMainThread(async () =>
                    {
                        await Navigation.PopAsync();
                        await DisplayAlert("Scanned Barcode", result.Text, "Success");
                        await Navigation.PushAsync(new JoinGroup());
                    });
                };
                needScan = false;
                await Navigation.PushAsync(scannerPage);
            }
            
        }

    }
}