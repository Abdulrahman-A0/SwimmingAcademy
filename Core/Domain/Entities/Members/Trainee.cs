using Domain.Entities.Base;
using Domain.Entities.Enrollments;
using Domain.Entities.Identity;
using Domain.Entities.Levels;


namespace Domain.Entities.Members
{
    public class Trainee : BaseEntity<int>
    {
        public string ApplicationUserId { get; set; }

        public int GuardianId { get; set; }

        public string FullName { get; set; }

        public DateTime BirthDate { get; set; }

        public int LevelId { get; set; }

        public string? MedicalNotes { get; set; }

        public bool IsActive { get; set; }

        #region Navigation Property

        public ApplicationUser User { get; set; }

        public Guardian Guardian { get; set; }

        public Level Level { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }

        #endregion
    }
}
