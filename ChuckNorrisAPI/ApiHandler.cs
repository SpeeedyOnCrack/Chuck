using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuckNorrisAPI
{
    public class ApiHandler
    {

        public async Task<Vtipy?> GetCrypto(string name)
        {
            try
            {
                RestClient client = new RestClient($"https://api.chucknorris.io/jokes/random");
                RestRequest request = new RestRequest();

                var response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    Console.WriteLine(response.Content);

                    Vtipy vtip = JsonConvert.DeserializeObject<Vtipy>(response.Content);

                    return vtip;
                }
                else
                {
                    Console.WriteLine($"Chyba: {response.StatusCode}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }
    }
}
