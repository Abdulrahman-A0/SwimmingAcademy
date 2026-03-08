using Domain.Entities.Members;
using Domain.Entities.Staff;
using Microsoft.AspNetCore.Identity;


namespace Domain.Entities.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedAt { get; set; }

        #region Navigation Property

        public Coach Coach { get; set; }
        public Guardian Guardian { get; set; }
        public Supervisor Supervisor { get; set; }

        #endregion
    }
}
