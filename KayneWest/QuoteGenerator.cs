using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Text;

namespace KayneWest
{
    
    public class QuoteGenerator
    {
        private HttpClient _client;
        public QuoteGenerator(HttpClient client)
        {
            _client = client;
        }
        public static void KanyeWest()
        {

            var client = new HttpClient();
            var kanyeURL = "https://api.kanye.rest";
            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
           
            Console.WriteLine(" -----------------------------------------");
            Console.WriteLine($"Kanye : {kanyeQuote}.");

        }
        public static void RonSwanson()
        {

            var client = new HttpClient();
            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var ronResponse = client.GetStringAsync(ronURL).Result;            
            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
                                                         //   ["I love nothing."]
            
            Console.WriteLine(" -----------------------------------------");
            Console.WriteLine($"RON : {ronQuote}.");

        }


        

       
    }
}
