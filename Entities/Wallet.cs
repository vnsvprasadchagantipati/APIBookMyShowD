using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIBookMyShowD.Entities
{

    public class Wallet
    {
        [Required]
        public string? walletId { get; set; }
       
        [Required]
        public string? UserId { get; set; }


        public double? balance { get; set; }
    }
}
