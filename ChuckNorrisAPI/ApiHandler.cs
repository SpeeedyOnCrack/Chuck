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
        public async Task<Vtipy> GetFact()
        {
            try
            {
                RestClient client = new RestClient("https://api.chucknorris.io/jokes/random");
                RestRequest request = new RestRequest();

                var response = await client.ExecuteAsync(request);

                if (response.IsSuccessful && !string.IsNullOrEmpty(response.Content))
                {
                    Console.WriteLine(response.Content);

                    Vtipy fact = JsonConvert.DeserializeObject<Vtipy>(response.Content);

                    return fact;
                }
                else
                {
                    Console.WriteLine("Failed.");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return null;
            }
        }
    }
}