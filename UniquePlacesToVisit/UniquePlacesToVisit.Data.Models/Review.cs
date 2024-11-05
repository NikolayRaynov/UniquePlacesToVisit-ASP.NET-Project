using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static UniquePlacesToVisit.Common.EntityValidationConstans.Review;

namespace UniquePlacesToVisit.Data.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength: ReviewTextMaxLength, MinimumLength = ReviewTextMinLength)]
        [Comment("User review for current destination")]
        public string ReviewText { get; set; } = null!;

        [Comment("Rating from user with range one to five stars")]
        public int Rating { get; set; }

        [Comment("Date on publish commnent")]
        public DateTime CreatedAt { get; set; }

        public int AttractionId { get; set; }

        [ForeignKey(nameof(AttractionId))]
        public virtual Attraction Attraction { get; set; } = null!;

        public Guid UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public virtual ApplicationUser User { get; set; } = null!;

        public virtual ICollection<Comment> Comments { get; set; } = new HashSet<Comment>();
    }

}
