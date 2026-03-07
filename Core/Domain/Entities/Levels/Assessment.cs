using Domain.Entities.Base;
using Domain.Entities.Classes;
using Domain.Entities.Members;
using Domain.Entities.Staff;


namespace Domain.Entities.Levels
{
    public class Assessment : BaseEntity<int>
    {
        public int TraineeId { get; set; }

        public int TransactionMonthlyClassId { get; set; }

        public int LevelId { get; set; }

        public string Result { get; set; }

        public string Notes { get; set; }

        public int AssessedByCoachId { get; set; }

        public DateTime AssessmentDate { get; set; }

        #region Navigation Property

        public Trainee Trainee { get; set; }

        public TransactionMonthlyClass TransactionMonthlyClass { get; set; }

        public Level Level { get; set; }

        public Coach AssessedByCoach { get; set; }

        #endregion
    }
}
