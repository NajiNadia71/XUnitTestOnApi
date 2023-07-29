using APIXUnitTest.DTO;
using APIXUnitTest.Model;
using AutoMapper;
public class CountryProfile : Profile
{
    public CountryProfile()
    {
        CreateMap<CountryDto, Country>().ForMember(dest => dest.CountryName, opt => opt.MapFrom(src => src.Name)).ForMember(dest => dest.CountryId, opt => opt.Ignore());
        CreateMap<Country, CountryDto>().ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.CountryName));
       // CreateMap<Country, CountryDto>().ForMember(dest => dest.Continent, opt => opt.MapFrom(src => src.Continent));
        //CreateMap<Country, CountryDto>().ForMember(dest => dest.Capital, opt => opt.MapFrom(src => src.Capital));
        //CreateMap<Country, CountryDto>().ForMember(dest => dest.Continent, opt => opt.MapFrom(src => src.Continent));
        //CreateMap<Country, CountryDto>().ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));
        //CreateMap<Country, CountryDto>().ForMember(dest => dest.Population, opt => opt.MapFrom(src => src.Population));
        //CreateMap<Country, CountryDto>().ForMember(dest => dest.SurfaceArea, opt => opt.MapFrom(src => src.SurfaceArea));


    }
}