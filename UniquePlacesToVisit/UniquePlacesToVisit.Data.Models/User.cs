using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniquePlacesToVisit.Data.Models
{
    public class User : IdentityUser<Guid>
    {
        public User()
        {
            this.Id = Guid.NewGuid();
        }
    }
}
