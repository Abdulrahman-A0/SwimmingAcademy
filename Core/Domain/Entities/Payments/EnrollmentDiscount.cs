using Domain.Entities.Base;
using Domain.Entities.Enrollments;

namespace Domain.Entities.Payments
{
    public class EnrollmentDiscount : BaseEntity<int>
    {
        public int EnrollmentId { get; set; }

        public int DiscountId { get; set; }

        public decimal AppliedAmount { get; set; }

        #region Navigation Property

        public Enrollment Enrollment { get; set; }

        public Discount Discount { get; set; }

        #endregion
    }
}
