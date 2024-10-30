using System.ComponentModel.DataAnnotations;

using static UniquePlacesToVisit.Common.EntityValidationConstans.City;

namespace UniquePlacesToVisit.Data.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength: CityNameMaxLength, MinimumLength = CityNameMinLength)]
        public string Name { get; set; } = null!;

        public virtual ICollection<Attraction> Attractions { get; set; } = new HashSet<Attraction>();
    }
}
