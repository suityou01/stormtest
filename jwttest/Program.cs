using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace jwttest
{
    class Program
    {
        static HttpClient client = new HttpClient();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            var response = client.PostAsJsonAsync(
                "https://auth-dev.storm-technologies.com/client/v1/token", new PostData{ UserName = "", Password = "", AppId = ""}).Result;
            Console.WriteLine(response);
        }

       
    }

    public class PostData
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string AppId { get; set; }
    }
}
