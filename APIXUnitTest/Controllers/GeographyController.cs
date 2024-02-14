using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using APIXUnitTest.Model;
using APIXUnitTest.Services;
using APIXUnitTest.VM;
using APIXUnitTest.DTO;
using AutoMapper;

namespace APIXUnitTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeographyController : ControllerBase
    {
        private readonly IGeographyService geographyService;
        private readonly IMapper _mapper;
        public GeographyController(IGeographyService _geographyService, IMapper mapper)
        {
            geographyService = _geographyService;
            _mapper = mapper;
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

        [HttpGet("CountryListWithMapper")]
        public List<CountryDto> CountryListWithMapper()
        {
            try
            {
                var CountryList = geographyService.GetCountryList();
                var countryDto = _mapper.Map<List<CountryDto>>(CountryList);
                return countryDto;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        [HttpGet("CountryListMethod")]
        public IEnumerable<CountryDto> CountryListMethod()
        {
            try
            {
                var CountryList = geographyService.GetCountryList();
                return CountryProfile.CountryToCountryDto(CountryList);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
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
        [HttpPost("addCountryMethod")]
        public Response AddCountryCorrect(CountryDto country)
        {
            try
            {
                var countryo = CountryProfile.CountryDtoToCountry(country);
                return geographyService.AddCountry(countryo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        [HttpPost("addCountryMapper")]
        public Response AddCountryMapper(CountryDto country)
        {
            try
            {
                var countryo = _mapper.Map<Country>(country);
                return geographyService.AddCountry(countryo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
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
        [HttpGet("GetContinentList")]
        public List<Continent> GetContinentList()
        {
            try
            {
                return geographyService.GetContinentList().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
