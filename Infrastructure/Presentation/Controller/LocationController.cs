
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceAbstraction.Contracts;
using Shared.DTOs;
using Shared.DTOs.LocationModule;

namespace Presentation.Controller
{
    public class LocationController(IServiceManager service) : ApiController
    {
        /// <summary>
        /// Creates a new Location in the system.
        /// </summary>
        /// <remarks>
        /// This endpoint allows administrators to create a new academy location.
        /// 
        /// Validation Rules:
        /// - Name cannot be empty
        /// - Address cannot be empty
        /// - City cannot be empty
        /// 
        /// Example Request:
        /// {
        ///   "name": "Downtown Branch",
        ///   "address": "123 Nile Street",
        ///   "city": "Cairo"
        /// }
        /// </remarks>
        /// <response code="200">Location created successfully</response>
        /// <response code="400">Validation error</response>
        [HttpPost("AddLocation")]
        [ProducesResponseType(typeof(AddEntityResultDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<AddEntityResultDTO>> AddLocation(AddLocationDTO dto)
            => Ok(await service.LocationService.AddLocationAsync(dto));

        /// <summary>
        /// Retrieves all locations.
        /// </summary>
        /// <remarks>
        /// Returns all swimming academy locations.
        /// </remarks>
        [HttpGet("GetAllLocations")]
        [ProducesResponseType(typeof(IEnumerable<LocationDTO>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<LocationDTO>>> GetAllLocations()
            => Ok(await service.LocationService.GetAllLocationsAsync());

        /// <summary>
        /// Updates an existing location.
        /// </summary>
        /// <remarks>
        /// Allows administrators to modify location details.
        /// </remarks>
        [HttpPut("UpdateLocation/{id}")]
        [ProducesResponseType(typeof(AddEntityResultDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<AddEntityResultDTO>> UpdateLocation(int id, UpdateLocationDTO dto)
            => Ok(await service.LocationService.UpdateLocationAsync(id, dto));

        /// <summary>
        /// Deletes a location.
        /// </summary>
        /// <remarks>
        /// Performs a soft delete by setting IsActive = false.
        /// </remarks>
        [HttpDelete("DeleteLocation/{id}")]
        [ProducesResponseType(typeof(AddEntityResultDTO), StatusCodes.Status200OK)]
        public async Task<ActionResult<AddEntityResultDTO>> DeleteLocation(int id)
            => Ok(await service.LocationService.DeleteLocationAsync(id));


    }
}
