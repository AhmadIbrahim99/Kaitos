using Kaitos.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace Kaitos.Data.DataBaseContext
{
    public class KatiosDbContext : IdentityDbContext
    {
        public bool IgnoreFilter { get; set; }
        public KatiosDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AboutUs>().HasQueryFilter(a=> a.DeletedAt == null || IgnoreFilter);
            builder.Entity<Blog>().HasQueryFilter(a=> a.DeletedAt == null || IgnoreFilter);
            builder.Entity<ContactUs>().HasQueryFilter(a=> a.DeletedAt == null || IgnoreFilter);
            builder.Entity<ServiceModel>().HasQueryFilter(a=> a.DeletedAt == null || IgnoreFilter);
            builder.Entity<MainPart>().HasQueryFilter(a=> a.DeletedAt == null || IgnoreFilter);
            builder.Entity<Setting>().HasQueryFilter(a=> a.DeletedAt == null || IgnoreFilter);
            base.OnModelCreating(builder);
        }

        public DbSet<AboutUs> AboutUs { get; set; } = null!;
        public DbSet<ApplicationUser> ApplicationUsers { get; set; } = null!;
        public DbSet<Blog> Blogs { get; set; } = null!;
        public DbSet<ContactUs> ContactUs { get; set; } = null!;
        public DbSet<MainPart> MainParts { get; set; } = null!;
        public DbSet<ServiceModel> Services { get; set; } = null!;
        public DbSet<Setting> Settings { get; set; } = null!;
    }
}
