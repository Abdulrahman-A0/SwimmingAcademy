
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


    }
}
