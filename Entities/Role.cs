using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIBookMyShowD.Entities

{
    public class Role
    {
        [Key]
        [Required]
        [StringLength(20)]
        [Column("Role",TypeName="varchar")]
        public string? RoleId { get; set; }

        [Required]
        [StringLength(20)]
        [Column("RoleName",TypeName = "varchar")]

        public string? RoleName { get; set; }
         

    }
}
