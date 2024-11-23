using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UniquePlacesToVisit.Common.EntityValidationConstans.City;
using static UniquePlacesToVisit.Common.EntityValidationConstans.Attraction;
using static UniquePlacesToVisit.Common.EntityValidationMessages.City;
using static UniquePlacesToVisit.Common.EntityValidationMessages.Attraction;

namespace UniquePlacesToVisit.Web.ViewModels.Attraction
{
    public class AttractionIndexViewModel
    {
        public int Id { get; set; }

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

        [Required(ErrorMessage = CityNameIsRequired)]
        [StringLength(maximumLength: CityNameMaxLength, MinimumLength = CityNameMinLength)]
        public string CityName { get; set; } = string.Empty;
    }
}
