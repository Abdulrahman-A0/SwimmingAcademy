

namespace Shared.DTOs.LocationModule
{
    /// <summary>
    /// DTO used to update an existing location.
    /// </summary>
    public class UpdateLocationDTO
    {
        /// <summary>
        /// Name of the location branch.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Address of the location.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// City where the location exists.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Determines whether the location is active.
        /// </summary>
        public bool IsActive { get; set; }
    }
}

