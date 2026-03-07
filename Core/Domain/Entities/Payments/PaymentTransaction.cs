using Domain.Entities.Base;
using Domain.Entities.Enrollments;


namespace Domain.Entities.Payments
{
    public class PaymentTransaction : BaseEntity<int>
    {
        public int EnrollmentId { get; set; }

        public decimal Amount { get; set; }

        public string PaymentMethod { get; set; }

        public string PaymentGateway { get; set; }

        public string GatewayTransactionId { get; set; }

        public string Status { get; set; }

        public DateTime? PaymentDate { get; set; }

        public DateTime CreatedAt { get; set; }

        #region Navigation Property

        public Enrollment Enrollment { get; set; }

        #endregion
    }
}
