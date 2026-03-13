using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs.LocationModule
{
    /// <summary>
    /// DTO used to return location data.
    /// </summary>
    public class LocationDTO
    {
        /// <summary>
        /// Location name.
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
        /// Indicates if the location is active.
        /// </summary>
        public bool IsActive { get; set; }
    }
}

