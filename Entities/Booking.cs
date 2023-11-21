using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using APIBookMyShowD.Database;

namespace APIBookMyShowD.Entities
{
    public class Booking
    {
        [Key]
        [Required ]
        public  Guid  BookingId{ get; set; }

        [Required]
        public string? UserId { get; set; }
        [Required]
        public string? MultiplexId { get; set; }
        [Required]
        public string? MovieId { get; set; }
        [ForeignKey("MovieId")]
        public Movie? Movies { get; set; }
        [ForeignKey("MultiplexId")]
        public Multiplex? Multiplex { get; set; }
        
        [ForeignKey("UserId")]
        public User? User { get; set; }
    }
}
