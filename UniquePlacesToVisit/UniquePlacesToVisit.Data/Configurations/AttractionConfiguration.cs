using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniquePlacesToVisit.Data.Models;

namespace UniquePlacesToVisit.Data.Configurations
{
    public class AttractionConfiguration : IEntityTypeConfiguration<Attraction>
    {
        public void Configure(EntityTypeBuilder<Attraction> builder)
        {
            builder
                .HasOne(a => a.City)
                .WithMany(a => a.Attractions)
                .OnDelete(DeleteBehavior.Restrict);
        }

        //public IEnumerable<Attraction> SeedAttractions()
        //{

        //}
    }
}
