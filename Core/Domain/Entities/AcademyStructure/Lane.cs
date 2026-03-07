using Domain.Entities.Base;
using Domain.Entities.Classes;

namespace Domain.Entities.AcademyStructure
{
    public class Lane : BaseEntity<int>
    {
        public int PoolId { get; set; }

        public int LaneNumber { get; set; }

        #region Navigation Property

        public Pool Pool { get; set; }

        public ICollection<TransactionMonthlyClassLane> MonthlyClassLanes { get; set; }

        #endregion
    }
}
