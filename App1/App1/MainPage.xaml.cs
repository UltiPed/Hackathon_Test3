using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        String result = "";
        public MainPage()
        {
            InitializeComponent();

            
          

        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            IMessage platform = Xamarin.Forms.DependencyService.Get<IMessage>();
            string json = platform.bowlingJson("Jesse", "Jake");
            platform.doSinglePayment();
            result = await Task.Run(() =>
                platform.run("https://raw.github.com/square/okhttp/master/README.md",json)
            );

            
            result = "";
        }
    }
}
