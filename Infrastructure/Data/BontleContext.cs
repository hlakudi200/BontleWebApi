
using core.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class BontleContext : DbContext
    {
        public BontleContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users{ get; set; }
        public DbSet<Professional> Professionals { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Availability> Availabilities { get; set; }
        public DbSet<Review> Reviews { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }

    }
}
