using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Core.DataLayer.Repository;
using Core.DataLayer.Interfaces;
using Core.Models;

namespace Core.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class BreweryDapperController : Controller
    {
        IBreweryManager _repo;
        public BreweryDapperController(IBreweryManager repo)
        {
            _repo = repo;
        }
        // GET: api/BreweryDapper
        [HttpGet]
        public IList<Brewery> Get()
        {
            return _repo.GetList();
        }

        // GET: api/BreweryDapper/5
        [HttpGet("{id}")]
        public Brewery Get(int id)
        {
            return _repo.GetBrewery(id);
        }
        
        // POST: api/BreweryDapper
        [HttpPost]
        public void Post([FromBody]Brewery brewery)
        {
            _repo.AddBrewery(brewery);
        }
        
        // PUT: api/BreweryDapper/5
        [HttpPut]
        public void Put([FromBody]Brewery brewery)
        {
            _repo.UpdateBrewery(brewery);
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repo.DeleteBrewery(id);
        }
    }
}
