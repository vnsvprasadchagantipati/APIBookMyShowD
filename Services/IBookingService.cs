using APIBookMyShowD.Entities;
namespace APIBookMyShowD.Services
{
    public interface IBookingService
    {
        void Add(Guid BookingId);
        void cancelBooking(Guid BookingId);



    }
}
