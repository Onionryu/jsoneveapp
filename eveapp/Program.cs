using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;

namespace eveapp
{
    class Program
    {

        static void Main(string[] args)
        {
            var repositories = ProcessRepositories().Result;
            Console.WriteLine("Begin!");
            try
            {
                foreach (var repo in repositories)
                {
                    Console.WriteLine("Something");
                    Console.WriteLine(repo.CorpId);
                    Console.WriteLine(repo.BDay);
                    Console.WriteLine(repo.Name);
                    Console.WriteLine(repo.Gender);
                    Console.WriteLine(repo.Race);
                    Console.WriteLine(repo.Bloodline);
                    Console.WriteLine(repo.Description);
                    Console.WriteLine(repo.Alliance);
                    Console.WriteLine(repo.Ancestry);
                    Console.WriteLine(repo.Security);
                    Console.WriteLine("Done!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            Console.ReadLine();
        }

        private static async Task<List<Repository>> ProcessRepositories()
        {

            var serializer = new DataContractJsonSerializer(typeof(List<Repository>));
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Add("User-Agent", "localhost");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            Console.WriteLine("Connection!");

            //documentation of the API is in https://esi.tech.ccp.is/latest/#!/Character/get_characters_character_id
            //var streamTask = client.GetStreamAsync("https://requestb.in/xvd3ovxv");
            var streamTask = client.GetStreamAsync("https://esi.tech.ccp.is/latest/characters/97138401/?datasource=tranquility");
            var repositories = serializer.ReadObject(await streamTask) as List<Repository>;
            Console.WriteLine("List done!");
            return repositories;

        }
    }
}
