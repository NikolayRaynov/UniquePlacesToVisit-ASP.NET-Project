using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniquePlacesToVisit.Web.ViewModels.Attraction
{
    using System.Collections.Generic;
    using UniquePlacesToVisit.Web.ViewModels.Review;

    public class AttractionDetailsViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Location { get; set; } = string.Empty;

        public string CityName { get; set; } = string.Empty;

        public string? ImagePath { get; set; }

        public List<ReviewViewModel> Reviews { get; set; } = new List<ReviewViewModel>();
    }

}
