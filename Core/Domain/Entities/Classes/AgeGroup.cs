using Domain.Entities.Base;


namespace Domain.Entities.Classes
{
    public class AgeGroup : BaseEntity<int>
    {
        public string Name { get; set; }

        public int MinAge { get; set; }

        public int MaxAge { get; set; }

        public bool IsActive { get; set; } = true;

        #region Navigation Property

        public ICollection<ClassTemplate> ClassTemplates { get; set; }

        #endregion
    }
}
