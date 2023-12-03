using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BDAT_1001_FinalProject_Access.Models.DTO;

namespace BDAT_1001_FinalProject_Access.Models.Domain
{
    public class DatabaseContext : IdentityDbContext<AppUsers>
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options):base(options)
        { 

        }
        public DbSet<BDAT_1001_FinalProject_Access.Models.DTO.RegisterModel>? RegisterModel { get; set; }

    }
}
