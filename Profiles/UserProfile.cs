using AutoMapper;
using APIBookMyShowD.Entities;
using APIBookMyShowD.DTO;
namespace APIBookMyShowD.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile() 
        {
            CreateMap<UserDTO, User>();
            CreateMap<User,UserDTO>();

        
        }
    }
}
