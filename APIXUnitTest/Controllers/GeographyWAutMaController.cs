using APIXUnitTest.DTO;
using APIXUnitTest.Model;
using APIXUnitTest.Services;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using AutoMapper.QueryableExtensions;

namespace APIXUnitTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeographyWAutMaController : ControllerBase
    {
        private readonly IGeographyService geographyService;
        private IMapper Mapper { get; }
        public GeographyWAutMaController(IMapper mapper, IGeographyService _geographyService)
        {
            this.Mapper = mapper;
            geographyService = _geographyService;
        }
        [HttpPost("FromContinentDtoToContinentEntity")]
        public Continent PostFromContinentDtoToContinentEntity([FromBody] ContinentDto continentDto)
        {
            return Mapper.Map<Continent>(continentDto);
        }
        [HttpGet("FromContinentEntityToContinentDto")]
        public IEnumerable< ContinentDto> PostFromContinentEntityToContinentDto()
        {
           var x = geographyService.GetContinentList().ToList();
           var y= Mapper.Map<IEnumerable<ContinentDto>>(x);

            return y;
        }
        [HttpPost("FromCountryDtoToCountryEntity")]
        public Country PostFromCountryDtoToCountryEntity([FromBody] CountryDto countryDto)
        {

            return Mapper.Map<Country>(countryDto);
        }
        [HttpGet("FromCountryEntityToCountryDto")]
        public IEnumerable<CountryDto> PostFromCountryEntityToCountryDto()
        {
           var x= geographyService.GetCountryList().ToList();
            var y = Mapper.Map<IEnumerable<CountryDto>>(x);

            return y;
        }
    }
}
