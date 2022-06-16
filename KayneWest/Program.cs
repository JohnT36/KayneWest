using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace KayneWest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var quote = new QuoteGenerator(client);

            QuoteGenerator.RonSwanson();
            Console.ReadLine();
            QuoteGenerator.KanyeWest();            
            QuoteGenerator.RonSwanson();
            Console.ReadLine();
            QuoteGenerator.KanyeWest();
            QuoteGenerator.RonSwanson();
            Console.ReadLine();
            QuoteGenerator.KanyeWest();
            Console.ReadLine();
            QuoteGenerator.KanyeWest();
            Console.ReadLine();
            QuoteGenerator.RonSwanson();            
            QuoteGenerator.KanyeWest();
            Console.ReadLine();
            QuoteGenerator.RonSwanson();
            QuoteGenerator.KanyeWest();
            Console.ReadLine();
            QuoteGenerator.RonSwanson();
            QuoteGenerator.KanyeWest();
            Console.ReadLine();
            QuoteGenerator.RonSwanson();

            // var client = new HttpClient();
            // var kanyeURL = "https://api.kanye.rest";
            // var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
            // var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
            // Console.WriteLine(kanyeQuote);
        }
    }
}
