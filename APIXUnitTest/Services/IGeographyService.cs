using APIXUnitTest.Model;
using APIXUnitTest.VM;

namespace APIXUnitTest.Services
{
    public interface IGeographyService
    {
        public IEnumerable<Country> GetCountryList();
        public Country GetCountryById(int id);
        public Response AddCountry (Country country);
        public Response UpdateCountry(Country country);
        public bool DeleteCountry(int Id);
        public IEnumerable<Continent> GetContinentList();
    }
}
