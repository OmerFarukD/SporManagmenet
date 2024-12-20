namespace SporManagmenet.WebApi.Models.Entities;

public class Coach : Entity<Guid>
{
    public string Name { get; set; }


    public int CountryId { get; set; }
    public Country Country { get; set; }


    public int TeamId { get; set; }
    public Team Team { get; set; }
}
