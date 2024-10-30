using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniquePlacesToVisit.Data.Models;

namespace UniquePlacesToVisit.Data.Configurations
{
    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder
                .HasOne(r => r.User)
                .WithMany(r => r.Reviews)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(r => r.Attraction)
                .WithMany(r => r.Reviews)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
