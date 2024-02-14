namespace APIXUnitTest.DTO
{
    public class CountryDto
    {
        public CountryDto() {
        Continent = new ContinentDto();
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Capital { get; set; }
        public int SurfaceArea { get; set; }
        public int Population { get; set; }
        public virtual ContinentDto? Continent { get; set; }
      
    }
}

