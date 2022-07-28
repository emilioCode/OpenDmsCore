using AutoMapper;
using OpenDmsCore.Core.DTOs;
using OpenDmsCore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenDmsCore.Infrastructure.Mappings
{
    public  class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<TeamDto, Team>();
            CreateMap<Team, TeamDto>();
        }
    }
}
