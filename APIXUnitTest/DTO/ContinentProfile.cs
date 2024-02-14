using APIXUnitTest.DTO;
using APIXUnitTest.Model;
using AutoMapper;
using Microsoft.Extensions.Logging;

public class ContinentProfile : Profile
{
    public ContinentProfile()
    {
        CreateMap<ContinentDto, Continent>().ForMember(dest => dest.ContinentName, opt => opt.MapFrom(src => src.Name)).ForMember(dest => dest.ContinentId, opt => opt.Ignore());
        CreateMap<Continent, ContinentDto>().ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.ContinentName));//.ForMember(dest => dest.Countrys, opt => opt.Ignore());
       
       


    }
}
