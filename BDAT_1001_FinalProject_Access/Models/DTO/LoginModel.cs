using System.ComponentModel.DataAnnotations;

namespace BDAT_1001_FinalProject_Access.Models.DTO
{
    public class LoginModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
