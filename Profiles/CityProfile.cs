using AutoMapper;
using APIBookMyShowD.DTO;
using APIBookMyShowD.Entities;

namespace APIBookMyShowD.Profiles
{
    public class CityProfile : Profile
    {
       public CityProfile() 
        
        {
          CreateMap<City,CityDTO>();
            CreateMap<CityDTO, City>();
        }

    }
}
