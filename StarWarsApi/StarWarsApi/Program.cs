using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using StarWarsApi.DataBase;
using System.IO;
using System.Net;

namespace StarWarsApi
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient client2 = new WebClient();
            var client = new RestClient("https://swapi.dev/api/planets/");
            var request = new RestRequest(Method.GET);
            var response = client.Execute(request);

            var planetas = JsonConvert.DeserializeObject<PlanetasModel>(response.Content);

            foreach (var p in planetas.results)
            {
                Console.WriteLine($"{p.name} rotation {p.diameter}");

                /*Console.WriteLine("Qual a Pesquisa?");
                //var query = Console.ReadLine();
                var endereco = ("https://www.google.com.br/search?q=" + $"{p.name}");
                //var endereco = ("https://www.google.com.br/search?q=" + query);
                //Process.Start("https://www.google.com.br/search?q=" + query);

                var recebe = client2.DownloadString(endereco);
                Console.WriteLine(recebe);

                string nomeArquivo = @"C:\GitHub\TesteVS2017\log - " + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";
                StreamWriter writer = new StreamWriter(nomeArquivo);
                writer.WriteLine(recebe);
                
                writer.Close();*/
            }

            Console.ReadLine();
        }
    }
}
