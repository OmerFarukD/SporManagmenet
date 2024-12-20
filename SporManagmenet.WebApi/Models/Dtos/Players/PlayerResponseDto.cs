using SporManagmenet.WebApi.Models.Enums;

namespace SporManagmenet.WebApi.Models.Dtos.Players;

public sealed record PlayerResponseDto
{

    public Guid Id { get; set; }

    public string Name { get; init; }

    public string Surname { get; init; }

    public int Age { get; init; }

    public int JerseyNumber { get; init; }
    public Branch Branch { get; init; }

    public Gender Gender { get; init; }

    public decimal Salary { get; init; }


    public string TeamName { get; init; }

    public string CountryName{ get; init; }
}