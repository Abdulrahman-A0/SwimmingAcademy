
using AutoMapper;
using Domain.Contracts;
using Domain.Entities.AcademyStructure;
using Domain.Exceptions.ValidationExceptions;
using ServiceAbstraction.Contracts;
using Shared.DTOs;
using Shared.DTOs.LocationModule;
using System.Net;

namespace Service.Implementations
{
    public class LocationService : ILocationService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        private readonly IGenericRepository<Location, int> locationRepo;

        public LocationService
            (
            IMapper mapper,
            IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;

            locationRepo = _unitOfWork.GetRepository<Location, int>();
        }

        public async Task<AddEntityResultDTO> AddLocationAsync(AddLocationDTO dto)
        {
            var location = _mapper.Map<Location>(dto);
            location.Name = location.Name.Trim();
            location.Address = location.Address.Trim();
            location.City = location.City.Trim();

            if(string.IsNullOrWhiteSpace(location.Name) || 
               string.IsNullOrWhiteSpace(location.Address)||
               string.IsNullOrWhiteSpace(location.City))
            {
                throw new LocationValidationException(
                   new Dictionary<string, string[]>
                   {
                       ["LocationContent"] = new[] { "Location attributes must contain text or media." }
                   });
            }

            await locationRepo.AddAsync(location);
            await _unitOfWork.SaveChangesAsync();

            return new AddEntityResultDTO
            {
                IsCreated = true,
                Message = "Added Successfully!"
            };

        }
    }
}
