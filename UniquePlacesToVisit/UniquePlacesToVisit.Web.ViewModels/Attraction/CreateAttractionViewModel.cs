using System.ComponentModel.DataAnnotations;
using static UniquePlacesToVisit.Common.EntityValidationConstans.Attraction;
using static UniquePlacesToVisit.Common.EntityValidationMessages.Attraction;

namespace UniquePlacesToVisit.Web.ViewModels.Attraction
{
    public class CreateAttractionViewModel
    {
        [Required(ErrorMessage = AttractionNameIsRequired)]
        [StringLength(maximumLength: LocationMaxLenth, MinimumLength = LocationMinLenth)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(MaxImagePathLength)]
        public string? ImagePath { get; set; }

        [Required(ErrorMessage = DescriptionIsRequired)]
        [StringLength(maximumLength: DescriptionMaxLenth, MinimumLength = DescriptionMinLenth)]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = LocationIsRequired)]
        [StringLength(maximumLength: LocationMaxLenth, MinimumLength = LocationMinLenth)]
        public string Location { get; set; } = string.Empty;
        public int CityId { get; set; }
    }
}
