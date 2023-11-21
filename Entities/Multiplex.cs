using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace APIBookMyShowD.Entities

{
    public class Multiplex

    {
        [Key]
        [Required]
        [StringLength(20)]
        public string? MultiplexId { get; set; }
        [Required]
        [StringLength(20)]
        public string? MultiplexName { get; set; }
      
        [Required]
        public string? CityId { get; set; }
        
        
        [Required]

        public int ScreenNumber  { get; set; }

        [ForeignKey("CityId")]

        public City? City { get; set; }
    }
}
        
