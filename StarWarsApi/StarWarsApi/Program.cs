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
            }

            Console.ReadLine();
        }
    }
}
