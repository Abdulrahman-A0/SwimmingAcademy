using Domain.Entities.AcademyStructure;
using Domain.Entities.Base;
using Domain.Entities.Identity;


namespace Domain.Entities.Staff
{
    public class Supervisor : BaseEntity<int>
    {
        public string ApplicationUserId { get; set; }

        public int LocationId { get; set; }

        public bool IsActive { get; set; }

        #region Navigation Property

        public ApplicationUser User { get; set; }

        public Location Location { get; set; }

        #endregion
    }
}
