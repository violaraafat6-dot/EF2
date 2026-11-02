using System;
using System.Collections.Generic;
using System.Text;

#region AppDb

using Microsoft.EntityFrameworkCore;

namespace EventHub
{
    public class AppDbContext : DbContext
    {
        public DbSet<Organizer> Organizers { get; set; }

        public DbSet<OrganizerProfile> OrganizerProfiles { get; set; }

        public DbSet<Event> Events { get; set; }

        public DbSet<Attendee> Attendees { get; set; }

        public DbSet<Badge> Badges { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=EventHubDB;Trusted_Connection=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Title)
                      .IsRequired();

                entity.Property(e => e.Description)
                      .IsRequired();

                entity.HasOne(e => e.Organizer)
                      .WithMany(o => o.Events)
                      .HasForeignKey(e => e.OrganizerId);
            });

            modelBuilder.ApplyConfiguration(new OrganizerProfileConfiguration());

            modelBuilder.ApplyConfiguration(new BadgeConfiguration());
        }
    }
}


#endregion