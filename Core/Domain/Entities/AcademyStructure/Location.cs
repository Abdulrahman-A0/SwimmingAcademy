using Domain.Entities.Base;
using Domain.Entities.Staff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.AcademyStructure
{
    public class Location : BaseEntity<int>
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public string City { get; set; }
        
        #region Navigation Property

        public ICollection<Pool> Pools { get; set; }

        public ICollection<Supervisor> Supervisors { get; set; }

        #endregion

    }
}
