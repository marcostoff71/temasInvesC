using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace _028_HttPOSTGET
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var n = await HttpJsonPru.GetPrubaJsonHttps();
            Console.WriteLine(n.Count);
        }
    }
    class HttpJsonPru
    {
        public static async Task<List<PrubaJsonHttp>> GetPrubaJsonHttps()
        {
            HttpClient me = new HttpClient();
            me.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/posts");
            me.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage clien = await me.GetAsync("https://jsonplaceholder.typicode.com/posts");
            HttpContent conte =  clien.Content;
            var lectura = await conte.ReadAsStreamAsync();

         
            return await JsonSerializer.DeserializeAsync<List<PrubaJsonHttp>>(lectura);

        }
    }
    class PrubaJsonHttp
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
    }
   
}
