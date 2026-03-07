using Domain.Entities.Base;
using Domain.Entities.Classes;
using Domain.Entities.Members;
using Domain.Entities.Payments;


namespace Domain.Entities.Enrollments
{
    public class Enrollment : BaseEntity<int>
    {
        public int TraineeId { get; set; }

        public int TransactionMonthlyClassId { get; set; }

        public DateTime EnrollmentDate { get; set; } = DateTime.UtcNow;

        public string Status { get; set; }

        public decimal FinalPrice { get; set; }

        public bool? IsAssessmentPassed { get; set; }

        #region Navigation Property

        public Trainee Trainee { get; set; }

        public TransactionMonthlyClass TransactionMonthlyClass { get; set; }

        public ICollection<EnrollmentDiscount> EnrollmentDiscounts { get; set; }

        public ICollection<PaymentTransaction> PaymentTransactions { get; set; }

        public ICollection<Attendance> Attendances { get; set; }

        #endregion
    }
}
