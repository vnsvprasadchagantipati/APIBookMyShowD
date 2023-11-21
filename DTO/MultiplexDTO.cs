using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace APIBookMyShowD.DTO
{
    public class MultiplexDTO
    {
        
        public string? MultiplexID { get; set; }
       
        public string? MultiplexName { get; set; }

        public string? CityId { get; set; }
       

        public int ScreenNumber { get; set; }



        
    }
}

