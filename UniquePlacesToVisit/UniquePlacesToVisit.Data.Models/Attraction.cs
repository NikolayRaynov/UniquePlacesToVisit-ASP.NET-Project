using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static UniquePlacesToVisit.Common.EntityValidationConstans.Attraction;

namespace UniquePlacesToVisit.Data.Models
{
    public class Attraction
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength: AttractionNameMaxLength, MinimumLength = AttractionNameMinLength)]
        [Comment("Attraction name")]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(maximumLength: DescriptionMaxLenth, MinimumLength = DescriptionMinLenth)]
        [Comment("Description to attraction in current city")]
        public string Description { get; set; } = null!;

        [Required]
        [StringLength(maximumLength: LocationMaxLenth, MinimumLength = LocationMinLenth)]
        [Comment("Location at attraction in current city")]
        public string Location { get; set; } = null!;

        public int CityId { get; set; }

        [ForeignKey(nameof(CityId))]
        public virtual City City { get; set; } = null!;

        public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}
