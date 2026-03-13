
using AutoMapper;
using Domain.Entities.AcademyStructure;
using Shared.DTOs.LocationModule;

namespace Service.MappingProfiles
{
    public class LocationProfile : Profile
    {
        public LocationProfile()
        {
            // Add Location
            CreateMap<AddLocationDTO, Location>()
                .ForMember(dest => dest.Id,
                    opt => opt.Ignore());
        }
    }
}
