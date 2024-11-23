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

            builder.HasData(SeedReviews());
        }

        private IEnumerable<Review> SeedReviews()
        {
            List<Review> reviews = new List<Review>()
            {
                new Review
                {
                    Id = 1,
                    ReviewText = "Много красиво място с невероятна история. Малко е встрани от пътя, но пътуването си заслужава!",
                    Rating = 5,
                    CreatedAt = DateTime.Now.AddDays(-10),
                    AttractionId = 1,
                    UserId = Guid.Parse("55bc6032-2837-41ec-8cb9-34a4c88cae5b")
                },
                new Review
                {
                    Id = 2,
                    ReviewText = "Много голям зоопарк със всякакви животни,които няма в никой друг зоопарк в България.",
                    Rating = 5,
                    CreatedAt = DateTime.Now.AddDays(-5),
                    AttractionId = 2,
                    UserId = Guid.Parse("55bc6032-2837-41ec-8cb9-34a4c88cae5b")
                },
                new Review
                {
                    Id = 3,
                    ReviewText = "Невероятно красиво място",
                    Rating = 5,
                    CreatedAt = DateTime.Now.AddDays(-2),
                    AttractionId = 3,
                    UserId = Guid.Parse("55bc6032-2837-41ec-8cb9-34a4c88cae5b")
                },
                new Review
                {
                    Id = 4,
                    ReviewText = "Задължително трябва да се посети",
                    Rating = 5,
                    CreatedAt = DateTime.Now.AddDays(-5),
                    AttractionId = 4,
                    UserId = Guid.Parse("55bc6032-2837-41ec-8cb9-34a4c88cae5b")
                }
            };

            return reviews;
        }
    }
}
