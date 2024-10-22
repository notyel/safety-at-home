﻿using AutoMapper;
using SafetyAtHome.Common.Models.Auth;
using SafetyAtHome.Common.Models.DTO.Auth;
using SafetyAtHome.Domain.Data.Entities.Auth;

namespace SafetyAtHome.Common.Mapping.MappingProfiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<User, UserModel>().ReverseMap();
        }
    }
}
