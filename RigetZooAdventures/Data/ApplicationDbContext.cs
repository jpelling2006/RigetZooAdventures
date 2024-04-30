using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RigetZooAdventures.Models;

namespace RigetZooAdventures.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<RigetZooAdventures.Models.Activities> Activities { get; set; } = default!;
        public DbSet<RigetZooAdventures.Models.Article> Article { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUser>()
                .Property(e => e.Title)
                .HasMaxLength(5);

            modelBuilder.Entity<ApplicationUser>()
                .Property(e => e.FirstName)
                .HasMaxLength(256);

            modelBuilder.Entity<ApplicationUser>()
                .Property(e => e.LastName)
                .HasMaxLength(256);

        }

        public DbSet<RigetZooAdventures.Models.Tickets> Tickets { get; set; } = default!;

        public DbSet<RigetZooAdventures.Models.HotelBooking> HotelBooking { get; set; } = default!;
    }
}
