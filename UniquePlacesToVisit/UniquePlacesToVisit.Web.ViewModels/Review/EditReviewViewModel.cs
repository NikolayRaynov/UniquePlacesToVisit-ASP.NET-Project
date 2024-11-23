using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniquePlacesToVisit.Web.ViewModels.Review
{
    public class EditReviewViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "Ревюто не може да надвишава 500 символа.")]
        public string ReviewText { get; set; } = string.Empty;

        [Range(1, 5)]
        public int Rating { get; set; }
    }

}
