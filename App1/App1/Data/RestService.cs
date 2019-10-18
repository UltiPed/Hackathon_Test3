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
            client.BaseAddress = new Uri("gateway.sandbox.tapngo.com.hk");
            client.MaxResponseContentBufferSize = 256000;
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/xml"));
        }

        public async Task SinglePaymentOrRequestRecurrentToken(String appId, String APIKey, String publicKey)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "/web/payments");
            request.Headers.Add("Content-Type", "application/x-www-form - urlencoded");
            var postData = new List<KeyValuePair<String, String>>();
            postData.Add(new KeyValuePair<string, string>("appId", appId));
            postData.Add(new KeyValuePair<string, string>("APIKey", APIKey));
            postData.Add(new KeyValuePair<string, string>("publicKey", publicKey));
        }
    }
}
