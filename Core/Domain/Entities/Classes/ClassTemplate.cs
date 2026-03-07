using Domain.Entities.Base;
using Domain.Entities.Levels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Classes
{
    public class ClassTemplate : BaseEntity<int>
    {
        public string Name { get; set; }

        public int LevelId { get; set; }

        public int AgeGroupId { get; set; }

        public int DefaultMinCapacity { get; set; }

        public int DefaultMaxCapacity { get; set; }

        public decimal DefaultPrice { get; set; }

        public int DefaultSessionsCount { get; set; }

        public bool IsPrivateDefault { get; set; }

        #region Navigation Property

        public Level Level { get; set; }

        public AgeGroup AgeGroup { get; set; }

        public ICollection<TransactionMonthlyClass> MonthlyClasses { get; set; }

        #endregion
    }
}
