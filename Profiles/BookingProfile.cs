using APIBookMyShowD.DTO;
using APIBookMyShowD.Entities;
using AutoMapper;
namespace APIBookMyShowD.Profiles
{
    public class BookingProfile : Profile
    {
        public BookingProfile() 
        {
         CreateMap<Booking,BookingDTO>();
         CreateMap<BookingDTO, Booking>();
        }
    }
}
