using SporManagmenet.WebApi.Models.Entities;

namespace SporManagmenet.WebApi.Models.Dtos.Teams;

public sealed record TeamResponseDto(int Id, string Name, string YearOfEstablishment)
{
    public static implicit operator TeamResponseDto(Team team)
    {
        return new TeamResponseDto(team.Id,team.Name,team.YearOfEstablishment);
    }
}
