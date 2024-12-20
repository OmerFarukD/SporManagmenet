using Microsoft.EntityFrameworkCore;
using SporManagmenet.WebApi.Models.Entities;

namespace SporManagmenet.WebApi.Repository.Contexts;

public class BaseDbContext : DbContext
{

    public BaseDbContext(DbContextOptions<BaseDbContext> options): base(options)
    {
        
    }



    public DbSet<Coach> Coaches{ get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Player> Players { get; set; }
    public DbSet<PlayerImage> PlayerImages { get; set; }
    public DbSet<Team> Teams { get; set; }

}
