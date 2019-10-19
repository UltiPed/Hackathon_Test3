using App1.Data;
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

        private async void btnconfirm_Clicked(object sender, EventArgs e)
        {
            RestService restService = new RestService();
            await restService.SinglePaymentOrRequestRecurrentToken("4224081940", "MIICIjANBgkqhkiG9w0BAQEFAAOCAg8AMIICCgKCAgEAn/bYMFqHRP+OHG/drijXyOPcGGwtlHb0gz1imaHRbzE1/DOp1IRW2dURzAmwfWKfMVLlAf3/QleTCwVq1hAc3gwyHLeEmICcZ0remLKEa1dxhKD3BsGRF+RdqBP4Q0wnMYQbMJFuLbhwTBRco0usPFfmqEB3rgULVUW/wTA9EDbjG8LWoMC+aXYiWig8KIe/FQiB8WbNSV7nvnjyEa/asQfUsNsdKdgGJF110jgkouYVfASZWu0nAP6UfXxdmFu3dVgkiNq/Z3nxpYj/lPYGZ4xoPhQOhtqRyjPRb6v1Ccu0rm9wbzWflsKrRE3HTSg/wb+wcKbmXS+/vsSYdsT0iIL24rB9ovwtS3526xsijFs+JtPqnMHpJIA36VQbrLHifBJr3DOk/ieIp56eR+fXITn+mqH4sHThHoXU9dWLMtI0K0l1p90dN2Lzpcxevttx+T3/n+OaJbzs3ub+S0nhW/BgbeNP9I4cBl9mxPLlOxNzZpYiobHVbKhqPqzYGzXCkZjLOrnULAlZb6NQlxiJIpPsw1jRJ8rJWtQZe0QTMmqlLOYmqmRs35j0tT6t9Twz0uFbzFZvs3HDY3+o9AO/wpE6ppbpMaHxskeUXiWHpDd+Vt6FSP2S2HnmR4FEN0v84HyQtSHMd0fBbwlMXM2cNKPC7kYapjdECmgnV/BuM+sCAwEAAQ==");

        }

        private void btncancel_Clicked(object sender, EventArgs e)
        {

        }
    }
}