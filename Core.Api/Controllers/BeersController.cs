using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Core.Api.Models;

namespace Core.Api.Controllers
{
    //[LogTimeFilter]
    [Route("api/[controller]")]
    public class BeersController : Controller
    {
        private CoreContext _coreContext; 
        public BeersController(CoreContext context)
        {
            _coreContext = context;
        }
        // GET: api/values
        [HttpGet]
        public JsonResult Get()
        {
            return Json(_coreContext.Beers);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            var result = _coreContext.Beers.SingleOrDefault(x => x.Id == id);
            return Json(result);
        }

        // POST api/values
        [HttpPost]
        public JsonResult Post([FromBody]Beers beer)
        {
            if (beer.Id != 0) return Json("Invalid Request");
            _coreContext.Beers.Add(beer);
            _coreContext.SaveChanges();
            return Json(beer);
        }

        // PUT api/values/5
        [HttpPut]
        public void Put([FromBody]Beers value)
        {
            var beer = _coreContext.Beers.SingleOrDefault(x => x.Id == value.Id);
            beer.Name = value.Name;
            beer.Ounces = value.Ounces;
            beer.Ibu = value.Ibu;
            beer.BreweryId = value.BreweryId;
            beer.Style = value.Style;
            _coreContext.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var beerToDelete = _coreContext.Beers.FirstOrDefault(x => x.Id == id);
            _coreContext.Beers.Remove(beerToDelete);
            _coreContext.SaveChanges();
        }
    }
}
