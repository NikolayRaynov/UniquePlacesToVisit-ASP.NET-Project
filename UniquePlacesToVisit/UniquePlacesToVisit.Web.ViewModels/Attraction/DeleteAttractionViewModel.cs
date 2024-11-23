using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniquePlacesToVisit.Web.ViewModels.Attraction
{
    public class DeleteAttractionViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Име")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Описание")]
        public string Description { get; set; } = string.Empty;

        [Display(Name = "Локация")]
        public string Location { get; set; } = string.Empty;

        [Display(Name = "Град")]
        public string CityName { get; set; } = string.Empty;
    }
}
