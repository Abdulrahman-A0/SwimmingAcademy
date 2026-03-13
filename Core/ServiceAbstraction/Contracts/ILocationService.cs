
using Shared.DTOs;
using Shared.DTOs.LocationModule;

namespace ServiceAbstraction.Contracts
{
    public interface ILocationService
    {
        Task<AddEntityResultDTO> AddLocationAsync(AddLocationDTO dto);
    }
}
