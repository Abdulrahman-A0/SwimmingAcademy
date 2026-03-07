using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.AcademyStructure
{
    public class PoolWorkingHour : BaseEntity<int>
    {
        public int PoolId { get; set; }

        public int DayOfWeek { get; set; }

        public TimeSpan OpeningHour { get; set; }

        public TimeSpan ClosingHour { get; set; }

        #region Navigation Property
        
        public Pool Pool { get; set; }
        
        #endregion
    }
}
