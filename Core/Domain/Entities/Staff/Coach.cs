using Domain.Entities.Base;
using Domain.Entities.Classes;
using Domain.Entities.Identity;


namespace Domain.Entities.Staff
{
    public class Coach : BaseEntity<int>
    {
        public string ApplicationUserId { get; set; }

        public decimal CommissionRate { get; set; }

        public DateTime HireDate { get; set; }

        public string Picture { get; set; }

        public bool IsActive { get; set; }

        #region Navigation Property

        public ApplicationUser User { get; set; }

        public ICollection<TransactionMonthlyClass> Classes { get; set; }

        #endregion
    }
}
