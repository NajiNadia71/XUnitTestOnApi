namespace APIXUnitTest.Model
{
    public class Continent
    {
        public Continent()
        {
            Countrys = new HashSet<Country>();
        }
        public int ContinentId { get; set; }
        public string ContinentName { get; set; }
        public string Description { get; set; }
        public string ContinentInformation { get; set; }
        public int SurfaceArea { get; set; }
        public int CountOfCountries { get; set; }
        public int Population  {get; set; }
        public virtual ICollection<Country> Countrys { get; } = new List<Country>();
    }
}
