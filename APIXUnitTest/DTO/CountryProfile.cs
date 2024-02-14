using APIXUnitTest.DTO;
using APIXUnitTest.Model;
using AutoMapper;
public class CountryProfile : Profile
{
    public CountryProfile()
    {
        #region Second approach Using AutoMapper
        CreateMap<CountryDto, Country>()
        .ForMember(dest => dest.CountryName, opt => opt.MapFrom(src => src.Name))
         .ForPath(dest => dest.Continent.ContinentId, opts => opts.MapFrom(src => src.Continent.ContinentId))
        .ForMember(dest => dest.Capital, opt => opt.MapFrom(src => src.Capital))
        .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
        .ForMember(dest => dest.Population, opt => opt.MapFrom(src => src.Population))
        .ForMember(dest => dest.SurfaceArea, opt => opt.MapFrom(src => src.SurfaceArea));



        CreateMap<Country, CountryDto>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.CountryName))
            .ForMember(dest => dest.Continent, opt => opt.MapFrom(src => src.Continent))
            .ForMember(dest => dest.Capital, opt => opt.MapFrom(src => src.Capital))
            .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
            .ForMember(dest => dest.Population, opt => opt.MapFrom(src => src.Population))
            .ForMember(dest => dest.SurfaceArea, opt => opt.MapFrom(src => src.SurfaceArea));

        // CreateMap<Country, CountryDto>().ForMember(dest => dest.Continent, opt => opt.MapFrom(src => src.Continent));
        //CreateMap<Country, CountryDto>().ForMember(dest => dest.Capital, opt => opt.MapFrom(src => src.Capital));
        //CreateMap<Country, CountryDto>().ForMember(dest => dest.Continent, opt => opt.MapFrom(src => src.Continent));
        //CreateMap<Country, CountryDto>().ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));
        //CreateMap<Country, CountryDto>().ForMember(dest => dest.Population, opt => opt.MapFrom(src => src.Population));
        //CreateMap<Country, CountryDto>().ForMember(dest => dest.SurfaceArea, opt => opt.MapFrom(src => src.SurfaceArea));
        #endregion

    }
    #region First approach
    public static List<CountryDto> CountryToCountryDto(IEnumerable<Country> countries)
    {

        var  countryDtos = new List<CountryDto>();
        foreach(var country in countries)
        {
            var countryDto= new CountryDto();
            countryDto.Name=country.CountryName;
            countryDto.Population=country.Population;
            countryDto.Continent = new ContinentDto 
            { ContinentId = country.Continent.ContinentId, Name = country.Continent.ContinentName };
            
            countryDto.Name=country.CountryName;
            countryDto.Capital=country.Capital;
            countryDto.Description=country.Description;
            countryDto.SurfaceArea=country.SurfaceArea;
            countryDtos.Add(countryDto);
        }
        return countryDtos;
    }
    public static Country  CountryDtoToCountry(CountryDto countryDto)
    {
        var country = new Country();
        country.CountryName = countryDto.Name;
        country.Population = countryDto.Population;
        country.Continent = new Continent
        { ContinentId = countryDto.Continent.ContinentId };
        country.Capital = countryDto.Capital;
        country.Description = countryDto.Description;
        country.SurfaceArea = countryDto.SurfaceArea;
        return country;
    }
    #endregion
}