using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Core.DataLayer;
using Core.Models;
using Core.Api.Filters;

namespace Core.Api.Controllers
{
    [LogTimeFilter]
    [Route("api/[controller]")]
    public class BeerController : Controller
    {
        private CoreContext _coreContext; 
        public BeerController(CoreContext context)
        {
            _coreContext = context;
        }
        // GET: api/values
        [HttpGet]
        public JsonResult Get()
        {
            return Json(_coreContext.Beer);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            var result = _coreContext.Beer.SingleOrDefault(x => x.BeerId == id);
            return Json(result);
        }

        // POST api/values
        [HttpPost]
        public JsonResult Post([FromBody]Beer beer)
        {
            if (beer.BeerId!= 0) return Json("Invalid Request");
            _coreContext.Beer.Add(beer);

            _coreContext.SaveChanges();
            return Json(beer);
        }

        // PUT api/values/5
        [HttpPut]
        public void Put([FromBody]Beer value)
        {
            var beer = _coreContext.Beer.SingleOrDefault(x => x.BeerId == value.BeerId);
            
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
            var beerToDelete = _coreContext.Beer.FirstOrDefault(x => x.BeerId == id);
            _coreContext.Beer.Remove(beerToDelete);
            _coreContext.SaveChanges();
        }
    }
}
