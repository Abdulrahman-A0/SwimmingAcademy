using Domain.Entities.Base;
using Domain.Entities.Identity;


namespace Domain.Entities.Enrollments
{
    public class Attendance : BaseEntity<int>   
    {
        public int EnrollmentId { get; set; }

        public DateTime SessionDate { get; set; }

        public string Status { get; set; }

        public string RecordedByUserId { get; set; }

        #region Navigation Property

        public Enrollment Enrollment { get; set; }

        public ApplicationUser RecordedByUser { get; set; }

        #endregion
    }
}
