using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniquePlacesToVisit.Data.Models
{
    public class Review
    {
        public int Id { get; set; }

        public string ReviewText { get; set; } = null!;

        public int Rating { get; set; }

        public DateTime CreatedAt { get; set; }

        public int AttractionId { get; set; }

        [ForeignKey(nameof(AttractionId))]
        public Attraction Attraction { get; set; } = null!;

        public string UserId { get; set; } = null!;

        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } = null!;
    }

}
