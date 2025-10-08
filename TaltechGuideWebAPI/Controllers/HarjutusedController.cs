using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TaltechGuideWebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HarjutusedController : ControllerBase
    {
        //https://localhost:4444/Harjutused/random-rand
        [HttpGet("random-rand")] 
        public int randomNumberGenerator()
        {   
            Random rand = new Random();
            int result = rand.Next();
            return result;
        }
        [HttpGet("birthyear/{year}")]
        public string howOldAmI(int year)
        {
            int age1 = 2025 - year;
            int age2 = 2025 - year - 1;
            return $"You are either " + age2 + " or " + age1 + " years old-";
        }
    }
}
