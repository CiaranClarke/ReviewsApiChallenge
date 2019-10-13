using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;
using System.Text;
using System.Net.Http.Headers;
using System.Net.Http;
using Newtonsoft.Json;

namespace ReviewsApi
{
    public class YelpApiClient
    {
        private const string yelpKey = "9SuwvcSC0q_-w4h0hu-nvtXTaJX0iOq3-oAQFq57N7ZFUjLwGrwRmWRfDwde2qCX_SS8aU7BnrPGIsiTBJR7PVR0bp-zG1PIqMs3Vjy433kVTfDvJ0bHyzfY_a6cXXYx";

        private static HttpClient GetHttpClient(string url)
        {
            var client = new HttpClient { BaseAddress = new Uri(url) };
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", yelpKey);
            return client;
        }

        private static async Task<T> GetAsync<T>(string url)
        {
            try
            {
                using (var client = GetHttpClient(url))
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        var result = JsonConvert.DeserializeObject<T>(json);
                        return result;
                    }

                    return default(T);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return default(T);
            }
        }

        public static async Task<T> RunAsync<T>(string url)
        {
            return await GetAsync<T>(url);
        }
    }
        
}
