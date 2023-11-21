
using APIBookMyShowD.DTO;
using APIBookMyShowD.Entities;
using AutoMapper;
    namespace APIBookMyShowD.Profiles
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
           CreateMap<Role,RoleDTO >();
           CreateMap<RoleDTO, Role>();
        }

    }
}
