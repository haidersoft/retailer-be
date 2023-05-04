
using Retail_BE.DBContext.Entities;
using Microsoft.EntityFrameworkCore;


namespace Retail_BE.DBContext
{
    public class ApplicationDBContext : DbContext
    {
        protected readonly IConfiguration _configuration;
        public ApplicationDBContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<UserRoles> UserRole { get; set; }
        public DbSet<UserPackages> UserPackages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                  .UseSqlite(_configuration.GetConnectionString("MyDbConnection"));
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserRoles>()
           .HasKey(ur => new { ur.UserId, ur.RoleId });

            modelBuilder.Entity<UserRoles>()
                .HasOne(ur => ur.Users)
                .WithMany(u => u.UserRoles)
                .HasForeignKey(ur => ur.UserId);

            modelBuilder.Entity<UserRoles>()
                .HasOne(ur => ur.Roles)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(ur => ur.RoleId);



            modelBuilder.Entity<UserPackages>()
          .HasKey(ur => new { ur.UserId, ur.PackageId });

            modelBuilder.Entity<UserPackages>()
                .HasOne(ur => ur.Users)
                .WithMany(u => u.UserPackages)
                .HasForeignKey(ur => ur.UserId);

            modelBuilder.Entity<UserPackages>()
                .HasOne(ur => ur.Packages)
                .WithMany(r => r.UserPackages)
                .HasForeignKey(ur => ur.PackageId);
        }
    }
}
