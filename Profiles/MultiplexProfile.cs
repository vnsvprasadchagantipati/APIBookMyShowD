using AutoMapper;
using APIBookMyShowD.Entities;
using APIBookMyShowD.DTO;
namespace APIBookMyShowD.Profiles
{
    public class MultiplexProfile : Profile
    {
       public MultiplexProfile() 
        {
            CreateMap<MultiplexDTO, Multiplex>();
            CreateMap<Multiplex,MultiplexDTO>();
        }

    }
}
