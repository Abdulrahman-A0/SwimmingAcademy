using Domain.Entities.Base;
using Domain.Entities.Identity;
using Domain.Entities.Staff;
using Domain.Entities.Enrollments;


namespace Domain.Entities.Classes
{
    public class TransactionMonthlyClass : BaseEntity<int>
    {
        public int TemplateId { get; set; }

        public int Month { get; set; }

        public int Year { get; set; }

        public int MinCapacity { get; set; }

        public int MaxCapacity { get; set; }

        public decimal Price { get; set; }

        public int SessionsCount { get; set; }

        public bool IsPrivate { get; set; }

        public int CoachId { get; set; }

        public string Status { get; set; }

        public int? CreatedFromClassId { get; set; }

        public string CreatedByUserId { get; set; }

        public DateTime CreatedAt { get; set; }

        public bool IsActive { get; set; }

        #region Navigation Property

        public ClassTemplate Template { get; set; }

        public Coach Coach { get; set; }

        public TransactionMonthlyClass CreatedFromClass { get; set; }

        public ApplicationUser CreatedByUser { get; set; }

        public ICollection<TimeSlot> TimeSlots { get; set; }

        public ICollection<TransactionMonthlyClassLane> ClassLanes { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }

        #endregion
    }
}
