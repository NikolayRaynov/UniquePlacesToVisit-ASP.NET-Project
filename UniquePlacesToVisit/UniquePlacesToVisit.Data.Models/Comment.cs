using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UniquePlacesToVisit.Common.EntityValidationConstans.Comment;

namespace UniquePlacesToVisit.Data.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength: ReCommentTextMaxLength, MinimumLength = ReCommentTextMinLength)]
        [Comment("Comments on people under other people post")]
        public string ReCommentText { get; set; } = null!;

        public DateTime CreatedAt { get; set; }

        public int ReviewId { get; set; }

        [ForeignKey(nameof(ReviewId))]
        public virtual Review Review { get; set; } = null!;

        public Guid UserId { get; set; } = Guid.NewGuid();

        [ForeignKey(nameof(UserId))]
        public virtual ApplicationUser User { get; set; } = null!;
    }

}
