using DataLayer.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Core.Api.Models
{
    public partial class Beers 
    {
        public int Id { get; set; }
        public string Abv { get; set; }
        public int Ibu { get; set; }
        public int Bid { get; set; }
        public string Name { get; set; }
        public string Style { get; set; }
        public int BreweryId { get; set; }
        public double Ounces { get; set; }
    }
}
