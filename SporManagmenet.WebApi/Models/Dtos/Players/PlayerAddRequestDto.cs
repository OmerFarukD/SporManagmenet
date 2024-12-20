using SporManagmenet.WebApi.Models.Enums;

namespace SporManagmenet.WebApi.Models.Dtos.Players;

public sealed record PlayerAddRequestDto
{

    public string Name { get; init; }

    public string Surname { get; init; }

    public int Age { get; init; }

    public int JerseyNumber { get; init; }
    public Branch Branch { get; init; }

    public Gender Gender { get; init; }

    public decimal Salary { get; init; }


    public int TeamId { get; init; }

    public int CountryId { get; init; }
}
