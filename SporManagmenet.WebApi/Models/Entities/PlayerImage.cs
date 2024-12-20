namespace SporManagmenet.WebApi.Models.Entities;

public class PlayerImage : Entity<Guid>
{
    public Guid PlayerId { get; set; }

    public Player Player { get; set; }

    public string Url { get; set; }
}
