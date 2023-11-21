
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace APIBookMyShowD.Entities

{
    public class Movie
    {
        [Key]
        [Required]
        [StringLength(20)]
        [Column("Movies",TypeName ="VARCHAR")]
        public string? MovieId { get; set; }
        [Required]
        [StringLength(30)]
        public string? MovieName { get; set; }

        [Required]
        [StringLength (100)]
        public string? MovieDescription { get; set; }

        public String? MultiplexID { get; set; }
       
        [ForeignKey("MultiplexID")]

        public Multiplex? Multiplex { get; set; }

    }
}
