namespace SporManagmenet.WebApi.Models.Entities;

public class Country : Entity<int>
{
    public string Name { get; set; }

    public List<Player> Players { get; set; }

    public List<Coach> Coaches { get; set; }
}
