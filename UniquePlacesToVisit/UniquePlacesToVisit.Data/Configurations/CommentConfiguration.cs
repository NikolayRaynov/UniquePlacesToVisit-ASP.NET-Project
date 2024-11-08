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

            builder.HasData(SeedComments());
        }

        private IEnumerable<Comment> SeedComments()
        {
            List<Comment> comments = new List<Comment>()
            {
                new Comment
                {
                    Id = 1,
                    ReCommentText = "Съгласен съм, мястото е уникално!",
                    CreatedAt = DateTime.Now.AddDays(-9),
                    ReviewId = 1,
                    UserId = Guid.Parse("1605a048-00a2-44ef-bddb-171cd11dd641")
                },
                new Comment
                {
                    Id = 2,
                    ReCommentText = "Част от животните липсваха.",
                    CreatedAt = DateTime.Now.AddDays(-4),
                    ReviewId = 2,
                    UserId = Guid.Parse("1605a048-00a2-44ef-bddb-171cd11dd641")
                },
                new Comment
                {
                    Id = 3,
                    ReCommentText = "Съгласен съм, мястото е уникално!",
                    CreatedAt = DateTime.Now.AddDays(-1),
                    ReviewId = 3,
                    UserId = Guid.Parse("1605a048-00a2-44ef-bddb-171cd11dd641")
                },
                new Comment
                {
                    Id = 4,
                    ReCommentText = "Съгласен съм, мястото е уникално!",
                    CreatedAt = DateTime.Now.AddDays(-3),
                    ReviewId = 4,
                    UserId = Guid.Parse("1605a048-00a2-44ef-bddb-171cd11dd641")
                }
            };

            return comments;
        }
    }
}
