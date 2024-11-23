using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniquePlacesToVisit.Data.Models;
using UniquePlacesToVisit.Web.ViewModels.Comment;

namespace UniquePlacesToVisit.Web.ViewModels.Review
{
    public class ReviewViewModel
    {
        public int Id { get; set; }
        public string ReviewText { get; set; } = string.Empty;
        public int Rating { get; set; }
        public DateTime CreatedAt { get; set; }
        public string UserName { get; set; } = string.Empty;
        public List<CommentViewModel> Comments { get; set; } = new List<CommentViewModel>();
        public bool IsUserReviewOwner { get; set; }
        public string UserId { get; set; } = string.Empty;

        public int AttractionId { get; set; }
    }

}
