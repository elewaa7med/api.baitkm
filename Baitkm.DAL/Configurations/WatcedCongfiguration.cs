using Baitkm.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Baitkm.DAL.Configurations
{
    public class WatcedCongfiguration : IEntityTypeConfiguration<Watched>
    {
        public void Configure(EntityTypeBuilder<Watched> builder)
        {
            builder.HasOne(aa => aa.Announcement)
               .WithMany(a => a.watcheds)
               .HasForeignKey(aa => aa.AnnouncementId)
               .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(aa => aa.User)
               .WithMany(a => a.Watcheds)
               .HasForeignKey(aa => aa.UserId)
               .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(aa => aa.Guest)
               .WithMany(a => a.Watcheds)
               .HasForeignKey(aa => aa.GuestId)
               .OnDelete(DeleteBehavior.Cascade);

            builder.HasKey(s => s.Id);
            builder.Property(p => p.CreatedDt)
                .IsRequired();
            builder.Property(p => p.UpdatedDt)
                .IsRequired();
            builder.Property(p => p.IsDeleted)
                .IsRequired()
                .HasDefaultValue(false);
        }
    }
}
