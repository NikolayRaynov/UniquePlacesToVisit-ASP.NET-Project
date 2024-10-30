using Microsoft.AspNetCore.Identity;

namespace UniquePlacesToVisit.Data.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid();
        }

        public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();
        public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}
