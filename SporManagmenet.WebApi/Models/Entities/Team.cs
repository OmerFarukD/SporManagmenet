using SporManagmenet.WebApi.Models.Dtos.Teams;

namespace SporManagmenet.WebApi.Models.Entities;

public class Team : Entity<int>
{

    public string Name { get; set; }

    public string YearOfEstablishment { get; set; }


    public List<Player> Players { get; set; }



    public static implicit operator Team(TeamAddRequestDto dto)
    {
        return new Team
        {
            Name = dto.Name,
            YearOfEstablishment = dto.YearOfEstablishment
        };
    }


    public static implicit operator Team(TeamUpdateRequestDto dto)
    {
        return new Team
        {
            Id = dto.Id,
            Name = dto.Name,
            YearOfEstablishment = dto.YearOfEstablishment
        };
    }
}
