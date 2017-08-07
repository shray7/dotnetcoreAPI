namespace Core.Models
{ 
    public class Beer 
    {
        public int BeerId { get; set; }
        public string Abv { get; set; }
        public int Ibu { get; set; }
        public int Bid { get; set; }
        public string Name { get; set; }
        public string Style { get; set; }
        public int BreweryId { get; set; }
        public double Ounces { get; set; }
    }
}
