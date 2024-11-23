using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniquePlacesToVisit.Web.ViewModels.Comment
{
    public class EditCommentViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "Коментарът не може да надвишава 500 символа.")]
        public string ReCommentText { get; set; } = string.Empty;
    }

}
