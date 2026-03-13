
namespace Shared.DTOs.LocationModule
{
    public class AddLocationDTO
    {
        /// <summary>
        /// Name of the academy location
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Street address of the location
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// City where the location is located
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// whether the location is active or not
        /// </summary>
        public bool IsActive { get; set; }

    }
}
