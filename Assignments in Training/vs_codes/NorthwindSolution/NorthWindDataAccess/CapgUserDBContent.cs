using Microsoft.EntityFrameworkCore;
using NorthwindEntities;

namespace NorthWindDataAccess
{
    public class CapgUserDBContent : DbContext

    {
        public CapgUserDBContent(DbContextOptions<CapgUserDBContent> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserRole>(entity => entity.HasKey("UserId", "RoleId"));

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

    }
}