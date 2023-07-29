using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using APIXUnitTest.Model;
using APIXUnitTest.Services;
using APIXUnitTest.VM;

namespace APIXUnitTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeographyController : ControllerBase
    {
        private readonly IGeographyService geographyService;
        public GeographyController(IGeographyService _geographyService)
        {
            geographyService = _geographyService;
        }
        [HttpGet("Countrylist")]
        public IEnumerable<Country> CountryList()
        {
            try
            {
                var CountryList = geographyService.GetCountryList();
                return CountryList;
            }
            catch(Exception ex)
            {
                throw new Exception( ex.Message );
            }
        }
        [HttpGet("getCountrybyid")]
        public Country GetCountryById(int Id)
        {
            try
            {
                return geographyService.GetCountryById(Id);
              }
            catch(Exception ex)
            {
                throw new Exception(ex.Message );
        }

        }
        [HttpPost("addCountry")]
        public Response AddCountry(Country country)
        {
            try
            {
                return geographyService.AddCountry(country);
             }
            catch(Exception ex)
            {
                throw new Exception(ex.Message );
            }
        }
        [HttpPut("updateCountry")]
        public Response UpdateCountry(Country country)
        {
            try
            {
                return geographyService.UpdateCountry(country);
        }
            catch(Exception ex)
            {
                throw new Exception(ex.Message );
         }
    }
        [HttpDelete("deleteCountry")]
        public bool DeleteCountry(int Id)
        {
            try
            {
                return geographyService.DeleteCountry(Id);
        }
            catch(Exception ex)
            {
                throw new Exception(ex.Message );
    }
}
    }
}
