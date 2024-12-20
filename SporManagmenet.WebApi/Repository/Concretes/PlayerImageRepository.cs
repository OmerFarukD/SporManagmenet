using SporManagmenet.WebApi.Models.Entities;
using SporManagmenet.WebApi.Repository.Abstracts;
using SporManagmenet.WebApi.Repository.Abstracts.EfBases;
using SporManagmenet.WebApi.Repository.Contexts;

namespace SporManagmenet.WebApi.Repository.Concretes;

public sealed class PlayerImageRepository : EfRepositoryBase<PlayerImage, Guid, BaseDbContext>, IPlayerImageRepository
{
    public PlayerImageRepository(BaseDbContext context) : base(context)
    {
    }
}
