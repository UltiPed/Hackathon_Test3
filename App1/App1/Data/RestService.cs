using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;

namespace App1.Data
{
    public class RestService
    {
        public HttpClient client;

        public RestService()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://gateway.sandbox.tapngo.com.hk");
            client.MaxResponseContentBufferSize = 256000;
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/xml"));


        }

        public async Task SinglePaymentOrRequestRecurrentToken(String appId, String publicKey)
        {

            List<string> sentence = new List<string>();
            int index = 0;
            string result = "---- - BEGIN PUBLIC KEY-----\n";
            publicKey = (publicKey.Trim());

            foreach (char c in publicKey)
            {
                //if smaller then 30 add to result
                if (index <= 64)
                {

                    //increase char index
                    index++;
                    result += c;

                }

                if (index == 64)
                {
                    //if index hits the first 30 chars add to list and clear result and index
                    result = result + "\n";
                    sentence.Add(result);
                    result = "";
                    index = 0;
                }


            }

            sentence.Add(result);
            sentence.Add("\n-----END PUBLIC KEY-----");
            string newkey = string.Join("", sentence); ;
            

               

            

            
            

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "web/payments");
            request.Headers.Add("Content-Type", "application/x-www-form - urlencoded");
            var postData = new List<KeyValuePair<String, String>>();
            postData.Add(new KeyValuePair<string, string>("appId", appId));
            postData.Add(new KeyValuePair<string, string>("paymentType", "S"));
            postData.Add(new KeyValuePair<string, string>("publicKey", publicKey));
            postData.Add(new KeyValuePair<string, string>("merTradeNo", "TEST20191019043015"));

        }


    }
}
