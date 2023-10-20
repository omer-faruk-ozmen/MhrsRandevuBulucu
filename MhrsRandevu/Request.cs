using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace MhrsRandevu
{
    public class Request
    {
        public string Get(string url, Dictionary<string, string> headers = null)
        {
            using (var client = new HttpClient())
            {
                if (headers != null)
                {
                    foreach (var key in headers)
                    {
                        client.DefaultRequestHeaders.Add(key.Key, key.Value);
                    }
                }

                var response = client.GetAsync(url).Result;
                return response.Content.ReadAsStringAsync().Result;
            }
        }

        public string Post(object body, string url, Dictionary<string, string> headers = null)
        {
            var jsonBody = JsonConvert.SerializeObject(body);
            var data = new StringContent(jsonBody, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                if (headers != null)
                {
                    foreach (var key in headers)
                    {
                        client.DefaultRequestHeaders.Add(key.Key, key.Value);
                    }
                }

                var response = client.PostAsync(url, data).Result;
                return response.Content.ReadAsStringAsync().Result;
            }
        }
    }
}
