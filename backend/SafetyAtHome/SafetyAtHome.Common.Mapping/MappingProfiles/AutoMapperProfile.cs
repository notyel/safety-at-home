using AutoMapper;
using SafetyAtHome.Common.Models.DTO.Auth;
using SafetyAtHome.Domain.Entities.Auth;

namespace SafetyAtHome.Common.Mapping.MappingProfiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDTO>().ReverseMap();
        }
    }
}
