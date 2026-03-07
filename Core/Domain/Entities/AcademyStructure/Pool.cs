using Domain.Entities.Base;

namespace Domain.Entities.AcademyStructure
{
    public class Pool : BaseEntity<int>
    {
        public int LocationId { get; set; }

        public string Name { get; set; }

        public bool IsActive { get; set; }

        #region Navigation Property
        public Location Location { get; set; }

        public ICollection<Lane> Lanes { get; set; }

        public ICollection<PoolWorkingHour> WorkingHours { get; set; }
        
        #endregion
    }
}
