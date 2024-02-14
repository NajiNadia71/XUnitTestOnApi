using APIXUnitTest.Model;

namespace APIXUnitTest.VM
{
    public class CountryVM
    {
        public CountryVM()
        {
            Continent = new ContinentVM();
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Capital { get; set; }
        public int SurfaceArea { get; set; }
        public int Population { get; set; }
        public ContinentVM Continent { get; set; }
    }
}
