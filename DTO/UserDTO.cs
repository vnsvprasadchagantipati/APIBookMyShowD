using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace APIBookMyShowD.DTO
{
    public class UserDTO
    {
        public string? UserId { get; set; }

        public string? UserName { get; set; }

        public string? UserEmail { get; set; }

        public string? Password { get; set; }

        public  string? RoleId { get; set; }
          

    }
}
