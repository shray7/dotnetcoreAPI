using Microsoft.AspNetCore.Mvc;
using System.IO;
using Newtonsoft.Json.Linq;
using Core.Api.Filters;

namespace Core.Api.Controllers
{
    [LogTimeFilter]
    [Route("api/[controller]")]
    public class PokemonController : Controller
    {
        private JArray PokemonList;
        public PokemonController()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string jsonLocation = Path.Combine(currentDirectory, "pokemon.json");
            PokemonList = JArray.Parse(System.IO.File.ReadAllText(jsonLocation));
        }

        // GET api/values
        [HttpGet]
        public JsonResult Get()
        {
            return Json(PokemonList);
        }

        // GET api/values/5
        [HttpGet("{id}")] 
        public JsonResult Get(int id)
        {
            if (id < 1 || id > 722) return Json("{Invalid Request}");
            return Json(PokemonList[id-1]);
        }

        // POST api/values
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        // PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        // DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
