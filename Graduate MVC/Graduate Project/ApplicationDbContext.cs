using Microsoft.EntityFrameworkCore;
using Graduate_Project.Models;

namespace Graduate_Project
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<ProfileModel> Profile { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) { }

    }
}
