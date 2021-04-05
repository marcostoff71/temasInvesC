using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Web;
using System.Net.Http;

namespace _025_Json
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //crear json serializar
            //Persona p1 = new Persona() { Edad = 23, Nombre = "Marco" };
            //string mijson = JsonConvert.SerializeObject(p1);
            //File.WriteAllText("texto.txt", mijson);

            ////obtener objeto deseraliza
            //string texot = File.ReadAllText("texto.txt");
            //Persona p2=JsonConvert.DeserializeObject<Persona>(texot);
            string url = "https://jsonplaceholder.typicode.com/posts";
            HttpClient clien = new HttpClient();

            var res= await clien.GetAsync(url);
            
            if (res.IsSuccessStatusCode)
            {
                var content = await res.Content.ReadAsStringAsync();
                var k= JsonConvert.DeserializeObject<List<Dese>>(content);
                foreach (var item in k)
                {
                    Console.WriteLine(item.body);
                }

            }
        }
    }
   class Dese
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
       
    }
    class Persona
    {
        public int Edad { get; set; }
        public string Nombre { get; set; }
    }
}
