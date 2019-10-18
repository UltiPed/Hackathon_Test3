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
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            ObservableCollection<String> alist = new ObservableCollection<String>();
            alist.Add("1");
            alist.Add("2");
            alist.Add("3");
            alist.Add("4");
            listview.ItemsSource = alist;

        }
    }
}