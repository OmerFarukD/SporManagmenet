namespace SporManagmenet.WebApi.Models.Dtos.Coachs;

public sealed record CoachResponseDto
{
    public Guid Id { get; init; }
    public string Name { get; init; }
    public string CountryName { get; init; }

    public string TeamName { get; set; }
}
