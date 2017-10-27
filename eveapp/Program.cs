using Newtonsoft.Json;
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
            var repo = ProcessRepositories().Result;
            try
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
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }

        private static async Task<Repository> ProcessRepositories()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //documentation of the API is in https://esi.tech.ccp.is/latest/#!/Character/get_characters_character_id
            //uses Newtonsoft.Json nuget
            var streamTask = client.GetStringAsync("https://esi.tech.ccp.is/latest/characters/97138401/?datasource=tranquility");
            Repository repositories = JsonConvert.DeserializeObject<Repository>(await streamTask);
            return repositories;
        }
    }
}
