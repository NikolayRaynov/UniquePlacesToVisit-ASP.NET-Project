using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniquePlacesToVisit.Web.ViewModels.Comment
{
    public class CommentViewModel
    {
        public int Id { get; set; }
        public string ReCommentText { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public string UserName { get; set; } = string.Empty;
        public bool IsUserCommentOwner { get; set; }
        public string UserId { get; set; } = string.Empty;
        public int ReviewId { get; set; }
    }
}
