using Domain.Entities.Base;
using Domain.Entities.Identity;

namespace Domain.Entities.Members
{
    public class Guardian : BaseEntity<int>
    {
        public string ApplicationUserId { get; set; }

        public string NationalId { get; set; }

        public string Address { get; set; }

        public bool IsActive { get; set; }

        #region Navigation Property

        public ApplicationUser User { get; set; }

        public ICollection<Trainee> Trainees { get; set; }

        #endregion
    }
}
