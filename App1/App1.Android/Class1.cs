using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using App1.Droid;
using Java.IO;
using Square.OkHttp3;
using Com.Hktpayment.Tapngosdk;


[assembly: Xamarin.Forms.Dependency(typeof(Class1))]
namespace App1.Droid
{
    public class Class1 : TapNGoPaymentActivity, IMessage
    {
        public static string[] appId = { "4444476236", "4206461909" , "4250328016" };
        public static string[] apiKey= { "xOu3lIS2SwYdYHXQXXIf8p7xsiGDjzBF3lKWBakRi2mH0q3vOP0JAI9bkauRhFSRsVqw18rwN8D1C65TChc0Jw==","zoCVzTw6nkyRA7VJLn4VxP62sJ/W+bPBOIrSYDyoIeFKiFJETYn3K5iWK3nExJqEUr3wwXjFTC4CpNSZ5+KPJQ==","ysP+PZ7Uk5QrGHb3Q7G8peqdeC8ZvA0IY0oPK+K3nPXXI2ouX/hcij47sIEHpla04TOEwkCSJhbnQaz7OZRjvg==" };
        public static string[] publicKey = { "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" };
        public static string currency = "HKD";

        public static String resultMessage = "";

        public static TapNGoPayment WEB_APP = new TapNGoPayment(appId[0], apiKey[0], publicKey[0]);
        public static TapNGoPayment BILL_QR = new TapNGoPayment(appId[1], apiKey[1], publicKey[1]);
        public static TapNGoPayment TXN_HIST = new TapNGoPayment(appId[2], apiKey[2], publicKey[2]);
        public static MediaType JSON = MediaType.Get("application/json; charset=utf-8");

        public Class1()
        {
            TapNGoSdkSettings.SetSandboxMode(true);

            TapNGoPayment payment = new TapNGoPayment(appId[0], apiKey[0], publicKey[0]);

            payment.SetSingleAndRecurrentPayment("1", 10, currency, null, null);




        }

        protected override void OnPaymentFail(TapNGoPayResult p0)
        {
            resultMessage = "Payment Failed";
        }

        protected override void OnPaymentSuccess(TapNGoPayResult p0)
        {
            resultMessage = "Payment Success";
        }

        public String TryPayment_WEB()
        {
            DoPayment(WEB_APP);
            return resultMessage;
        }

        public string run(string url,string json)
        {
            OkHttpClient client = new OkHttpClient();

            Request request = new Request.Builder()
            .Url(url)
            .Build();

            Response response;

            try
            {
                response = client.NewCall(request).Execute();
            }
            catch (IOException IO) { return IO.ToString(); };

            return response.Body().ToString();
        }

        public string bowlingJson(String player1, String player2)
        {


            return "{'winCondition':'HIGH_SCORE',"+ "'name':'Bowling',"+ "'round':4," + "'lastSaved':1367702411696,"
        + "'dateStarted':1367702378785,"+ "'players':["+ "{'name':'" + player1 + "','history':[10,8,6,7,8],'color':-13388315,'total':39},"
        + "{'name':'" + player2 + "','history':[6,10,5,10,10],'color':-48060,'total':41}"
        + "]}";
        }
        }
}