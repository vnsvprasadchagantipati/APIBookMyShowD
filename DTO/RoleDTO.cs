using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace APIBookMyShowD.DTO
{
    public class RoleDTO
    {
        public string? RoleId { get; set; }

        public string? RoleName { get; set; }
    }
}
