using AutoMapper;
using SporManagmenet.WebApi.Models.Dtos.Coachs;
using SporManagmenet.WebApi.Models.Dtos.Country;
using SporManagmenet.WebApi.Models.Dtos.PlayerImages;
using SporManagmenet.WebApi.Models.Dtos.Players;
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


        // Country Profiles
        CreateMap<Country,CountryResponseDto>();
        CreateMap<CountryAddRequestDto, Country>();
        CreateMap<CountryUpdateRequestDto, Country>();


        //Player Profiles
        CreateMap<Player, PlayerResponseDto>();
        CreateMap<PlayerAddRequestDto, Player>();
        CreateMap<PlayerUpdateRequestDto, Player>();
        CreateMap<Player, PlayerDetailResponseDto>()
            .ForMember(x => x.Images, opt => opt.MapFrom(x => x.PlayerImages.Select(p => p.Url).ToList()));



        CreateMap<PlayerImageAddRequestDto, Player>();
        CreateMap<PlayerImage, PlayerImageResponseDto>();
        CreateMap<PlayerImageUpdateRequestDto,PlayerImage>();
    }
}
