using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UniquePlacesToVisit.Common.EntityValidationConstans.City;
using static UniquePlacesToVisit.Common.EntityValidationMessages.City;

namespace UniquePlacesToVisit.Web.ViewModels.City
{
    public class CreateCityViewModel
    {
        [Required(ErrorMessage = CityNameIsRequired)]
        [StringLength(maximumLength: CityNameMaxLength, MinimumLength = CityNameMinLength)]
        public string Name { get; set; } = null!;
    }
}
