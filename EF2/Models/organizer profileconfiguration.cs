using System;
using System.Collections.Generic;
using System.Text;

#region opconfiguration

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventHub
{
    public class OrganizerProfileConfiguration
        : IEntityTypeConfiguration<OrganizerProfile>
    {
        public void Configure(EntityTypeBuilder<OrganizerProfile> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Biography)
                   .IsRequired();

            builder.HasOne(p => p.Organizer)
                   .WithOne(o => o.Profile)
                   .HasForeignKey<OrganizerProfile>(p => p.OrganizerId);
        }
    }
}
#endregion