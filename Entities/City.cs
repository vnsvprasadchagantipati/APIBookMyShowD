using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.NetworkInformation;

namespace APIBookMyShowD.Entities

{
     public class City
        {
            [Key]
            [Required]
            [StringLength(10)]
            public string? CityId { get; set; }
           
        
        [Required]
        [StringLength(30)]
        public string? CityName { get; set; }
        }
 }

