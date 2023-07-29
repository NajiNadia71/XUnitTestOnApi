using APIXUnitTest.Services;
using APIXUnitTest.Data;
using APIXUnitTest.Model;
using APIXUnitTest.VM;

namespace APIXUnitTest.Services
{
    public class GeographyService : IGeographyService
    {
        private readonly DbContextClass _dbContext;
        public GeographyService(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Country> GetCountryList()
        {
            return _dbContext.Countries.ToList();
        }
        public Country GetCountryById(int id)
        {
            return _dbContext.Countries.Where(x => x.Id == id).FirstOrDefault();
        }
        public Response AddCountry(Country country)
        {
            var res = new Response();
            try
            {
                var countryo = new Country();
                countryo.Id = country.Id;
                countryo.Description = country.Description;
                countryo.Name = country.Name;
                _dbContext.Add(countryo);
                res.Message = "Ok";
                return res;
            }
            catch (Exception ex)
            {
                res.Message = "NotOK";
                return res;
            }
        }
        public Response UpdateCountry(Country country)
        {
            var res = new Response();
            try
            {
                var item = _dbContext.Countries.Where(i => i.Id == country.Id).FirstOrDefault();
                var countryo = new Country();
                countryo.Description = country.Description;
                countryo.Name = country.Name;
                res.Message = "Ok";
                return res;
            }
            catch (Exception ex)
            {
                res.Message = "NotOK";
                return res;
            }
        }
        public bool DeleteCountry(int Id)
        {
            var filteredData = _dbContext.Countries.Where(x => x.Id == Id).FirstOrDefault();
            var result = _dbContext.Remove(filteredData);
            _dbContext.SaveChanges();
            return result != null ? true : false;
        }
    }
}