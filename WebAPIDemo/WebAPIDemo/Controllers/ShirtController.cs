using Microsoft.AspNetCore.Mvc;
using WebAPIDemo.Models;

namespace WebAPIDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShirtController : ControllerBase
    {
        [HttpGet]
        public string GetShirts()
        {
            return "Reading all the shirts";
        }

        //[HttpGet("{id}")]

        //public string GetShirt(int id, [FromQuery] string color)
        //{
        //    return $"Reading shirt:{id}, Color: {color}";
        //}

        [HttpGet("{id}")]

        public string GetShirt(int id, [FromHeader(Name ="Color")] string color)
        {
            return $"Reading shirt:{id}, Color: {color}";
        }

        //[HttpPost]
        //public string CreateShirt([FromBody] Shirt shirt)
        //{
        //    return $"Creating a new shirt";
        //}

        [HttpPost]
        public string CreateShirt([FromBody] Shirt shirt)
        {
            return $"Creating a new shirt";
        }

        [HttpPut("{id}")]
        public string UpdateShirt(int id)
        {
            return $"Updating shirt with id {id}";
        }

        [HttpDelete("{id}")]
        public string DeleteShirt(int id)
        {
            return $"Deleting shirt with id {id}";
        }
    }
}
