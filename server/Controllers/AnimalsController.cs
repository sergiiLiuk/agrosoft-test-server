 
using Microsoft.AspNetCore.Mvc;
using server.Models;
using Newtonsoft.Json;

namespace server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
 

    public class AnimalsController : ControllerBase
    {
        [HttpGet]
        public async Task<List<Animal>> GetAnimals()
        {
            var result = new List<Animal>();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://agrovisioncodingtest.azurewebsites.net/Animals"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var stringResponse = await response.Content.ReadAsStringAsync();
                        result.Add(JsonConvert.DeserializeObject<Animal>(stringResponse));
                    }
                    else
                    {
                        throw new HttpRequestException(response.ReasonPhrase);
                    }

                }
            }
            
            return result;
        }       

    }
     
}
