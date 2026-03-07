using Domain.Entities.Base;
using Domain.Entities.Identity;

namespace Domain.Entities.Audit
{
    public class AuditLog : BaseEntity<int>
    {
        public string UserId { get; set; }

        public string TableName { get; set; }

        public int RecordId { get; set; }

        public string ActionType { get; set; }

        public string OldValues { get; set; }

        public string NewValues { get; set; }

        public DateTime CreatedAt { get; set; }


        #region Navigation Property

        public ApplicationUser User { get; set; }

        #endregion
    }
}
