using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using CommandLine;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ReviewsApi.Models;

namespace ReviewsApi
{
    public class Program
    {
        private const string yelpUrl = "https://api.yelp.com/";
        private const string yelp_search = "v3/businesses/search";
        private const string yelp_business = "v3/businesses/";
        private const string yelp_review = "/reviews";
        private const int limit = 1;

        public static void Main(string[] args)
        {
            /*
               Use GetGoogleReviews(term, latitude, longitude).Result to receive data from google reviews
             
               Use GetYelpReviews(term, latitude, longitude) to receive data from Yelp reviews
             */

            CreateHostBuilder(args).Build().Run();
        }

        public static async Task<RootObject> GetGoogleReviews(string keyword, string latitude, string longitude)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage placeResponse = await client.GetAsync(string.Format("https://maps.googleapis.com/maps/api/place/nearbysearch/json?keyword={2}&location={0},{1}&radius=500&key=AIzaSyAbRn9laIwka61USPMKE-pa7hQPku_Qu5Y", latitude, longitude, keyword));

                var placeJson = await placeResponse.Content.ReadAsStringAsync();
                var placeResult = JsonConvert.DeserializeObject<PlacesApiResponse>(placeJson);

                string placeId = placeResult.result.FirstOrDefault().place_id;

                HttpResponseMessage response = await client.GetAsync(string.Format("https://maps.googleapis.com/maps/api/place/details/json?place_id={0}&key=AIzaSyAbRn9laIwka61USPMKE-pa7hQPku_Qu5Y", placeId));
                var json = await placeResponse.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<RootObject>(json);

                return result;
            }
        }

        public static Review GetYelpReviews(string term, string latitude, string longitude)
        {
            var builder = new UriBuilder(yelpUrl + yelp_search);
            var query = HttpUtility.ParseQueryString(builder.Query);
            query["term"] = term;
            query["latitude"] = latitude;
            query["longitude"] = longitude;
            builder.Query = query.ToString();
            string url = builder.ToString();
            
            var result = YelpApiClient.RunAsync<Business>(url).GetAwaiter().GetResult();
            string id = result.businesses.FirstOrDefault().Id;

            var reviewBuilder = new UriBuilder(yelpUrl + yelp_business + id + yelp_review);
            var queryReview = HttpUtility.ParseQueryString(builder.Query);
            reviewBuilder.Query = queryReview.ToString();
            string urlReview = reviewBuilder.ToString();

            var response = YelpApiClient.RunAsync<Review>(urlReview).GetAwaiter().GetResult();

            return response;
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

    }
}
