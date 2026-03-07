using Domain.Entities.AcademyStructure;
using Domain.Entities.Base;

namespace Domain.Entities.Classes
{
    public class TransactionMonthlyClassLane : BaseEntity<int>
    {
        public int TransactionMonthlyClassId { get; set; }

        public int LaneId { get; set; }

        #region Navigation Property
        public TransactionMonthlyClass TransactionMonthlyClass { get; set; }

        public Lane Lane { get; set; }

        #endregion
    }
}
