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
            foreach (var repo in repositories)
            {
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
                Console.WriteLine();
            }
            
            Console.ReadLine();
        }

        private static async Task<List<Repository>> ProcessRepositories()
        {

            var serializer = new DataContractJsonSerializer(typeof(List<Repository>));
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            //client.DefaultRequestHeaders.Add("X-User-Agent", "");


            //documentation of the API is in https://esi.tech.ccp.is/latest/#!/Character/get_characters_character_id
            var streamTask = client.GetStreamAsync("https://esi.tech.ccp.is/latest/characters/97138401/?datasource=tranquility");
            var repositories = serializer.ReadObject(await streamTask) as List<Repository>;
            return repositories;
            //var repositories = serializer.ReadObject(await streamTask) as List<Repository>;
            //var stringTask = client.GetStringAsync("https://api.github.com/orgs/dotnet/repos");
            //var msg = await stringTask;    
            //Console.Write(msg);

        }
    }
}
