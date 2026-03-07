using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Classes
{
    public class TimeSlot : BaseEntity<int>
    {
        public int TransactionMonthlyClassId { get; set; }

        public int DayOfWeek { get; set; }

        public TimeSpan StartTime { get; set; }

        public TimeSpan EndTime { get; set; }

        #region Navigation Property

        public TransactionMonthlyClass TransactionMonthlyClass { get; set; }

        #endregion
    }
}
