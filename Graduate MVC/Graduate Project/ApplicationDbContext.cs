using Microsoft.EntityFrameworkCore;
using Graduate_Project.Models;
using Graduate_Project.ViewModels;

namespace Graduate_Project
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<ProfileModel> Profile { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :  base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProfileModel>().ToTable("Profile");
        }

    }
}
