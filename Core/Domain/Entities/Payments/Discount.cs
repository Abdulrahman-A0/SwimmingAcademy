using Domain.Entities.Base;


namespace Domain.Entities.Payments
{
    public class Discount : BaseEntity<int>
    {
        public string Type { get; set; }

        public decimal Percentage { get; set; }

        public DateTime? ValidFrom { get; set; }

        public DateTime? ValidTo { get; set; }

        public bool IsActive { get; set; }

        #region Navigation Property

        public ICollection<EnrollmentDiscount> EnrollmentDiscounts { get; set; }

        #endregion
    }
}
