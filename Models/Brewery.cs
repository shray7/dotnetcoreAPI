using System.ComponentModel.DataAnnotations;

namespace Core.Api.Models
{
    public class Brewery 
    {
        public int BreweryId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
