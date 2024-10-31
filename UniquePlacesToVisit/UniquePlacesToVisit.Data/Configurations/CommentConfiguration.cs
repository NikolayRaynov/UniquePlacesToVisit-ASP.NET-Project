using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniquePlacesToVisit.Data.Models;

namespace UniquePlacesToVisit.Data.Configurations
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder
                .HasOne(c => c.Review)
                .WithMany(c => c.Comments)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(c => c.User)
                .WithMany(c => c.Comments)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
