using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Identity
{
    public class Role : BaseEntity<int>
    {
        public string Name { get; set; }

        public ICollection<ApplicationUser> Users { get; set; }
    }
}
