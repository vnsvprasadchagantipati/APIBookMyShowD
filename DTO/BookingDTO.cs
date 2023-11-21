using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace APIBookMyShowD.DTO
{
    public class BookingDTO
    {
        public Guid BookingId { get; set; }

       
        public string? UserId { get; set; }
       
        public string? MultiplexId { get; set; }
        
        public string? MovieId { get; set; }

    }
}
