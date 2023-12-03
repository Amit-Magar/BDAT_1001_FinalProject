using Microsoft.AspNetCore.Identity;

namespace BDAT_1001_FinalProject_Access.Models.Domain
{
    public class AppUsers:IdentityUser
    {
        public int Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }
    }
}
