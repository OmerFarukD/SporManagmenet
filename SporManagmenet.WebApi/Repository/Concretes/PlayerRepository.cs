using SporManagmenet.WebApi.Models.Entities;
using SporManagmenet.WebApi.Repository.Abstracts;
using SporManagmenet.WebApi.Repository.Abstracts.EfBases;
using SporManagmenet.WebApi.Repository.Contexts;

namespace SporManagmenet.WebApi.Repository.Concretes;

public sealed class PlayerRepository : EfRepositoryBase<Player, Guid, BaseDbContext>, IPlayerRepository
{
    public PlayerRepository(BaseDbContext context) : base(context)
    {
    }
}
