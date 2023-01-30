using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunAsync().Wait();
        }
        private static async Task RunAsync()
        {
            HttpClient klient = new HttpClient();
            klient.BaseAddress = new Uri("http://localhost:58355/");
            klient.DefaultRequestHeaders.Accept.Clear();
            klient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            //HttpRequestMessage odgovor = await klient.GetAsync("api/Produkti/1");
            //if (odgovor.IsSuccessStatusCode)
            //{
            //    Product p = await odgovor.Content.ReadAsAsync<Product>();
            //    Console.WriteLine(p.Ime+" "+p.Cena);
            //}
            HttpRequestMessage odgovor = await klient.GetAsync("api/Produkti/1");
            if (odgovor.IsSuccessStatusCode)
            {
                List<Product> vsi = await odgovor.Content.ReadAsAsync < List > Product >> ();
                foreach (var p in vsi)
                {
                    Console.WriteLine(p.Ime + " " + p.Cena);
                }
            }
            Console.ReadLine();
        }
    }
}
