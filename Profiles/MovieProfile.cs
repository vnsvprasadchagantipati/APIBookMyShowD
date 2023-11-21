using AutoMapper;
using APIBookMyShowD.Entities;
using APIBookMyShowD.DTO;

namespace APIBookMyShowD.Profiles
{
    public class MovieProfile : Profile
    {

        public MovieProfile() 
        {
          CreateMap<Movie,MoviesDTO>();
            CreateMap<MoviesDTO,Movie>();
        }
    }
}
