using Domain.Entities.Base;
using Domain.Entities.Classes;
using Domain.Entities.Members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Levels
{
    public class Level : BaseEntity<int>
    {
        public string Name { get; set; }

        public int OrderNumber { get; set; }

        public bool IsActive { get; set; }

        #region Navigation Property

        public ICollection<Trainee> Trainees { get; set; }

        public ICollection<ClassTemplate> ClassTemplates { get; set; }

        #endregion
    }
}
