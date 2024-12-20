using AutoMapper;
using SporManagmenet.WebApi.Models.Dtos.Coachs;
using SporManagmenet.WebApi.Models.Entities;

namespace SporManagmenet.WebApi.Services.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        // Coach Profiles

        CreateMap<CoachAddRequestDto, Coach>();
        CreateMap<CoachUpdateRequestDto, Coach>();
        CreateMap<Coach, CoachResponseDto>().ReverseMap();
    }
}
