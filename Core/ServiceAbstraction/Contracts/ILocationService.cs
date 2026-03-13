
using Shared.DTOs;
using Shared.DTOs.LocationModule;

namespace ServiceAbstraction.Contracts
{
    public interface ILocationService
    {
        Task<AddEntityResultDTO> AddLocationAsync(AddLocationDTO dto);
        Task<IEnumerable<LocationDTO>> GetAllLocationsAsync();
        Task<AddEntityResultDTO> UpdateLocationAsync(int id, UpdateLocationDTO dto);
        Task<AddEntityResultDTO> DeleteLocationAsync(int id);
    }
}
