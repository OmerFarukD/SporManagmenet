using SporManagmenet.WebApi.Models.Entities;
using SporManagmenet.WebApi.Repository.Abstracts;
using SporManagmenet.WebApi.Repository.Abstracts.EfBases;
using SporManagmenet.WebApi.Repository.Contexts;

namespace SporManagmenet.WebApi.Repository.Concretes;

public sealed class CountryRepository : EfRepositoryBase<Country, int, BaseDbContext>, ICountryRepository
{
    public CountryRepository(BaseDbContext context) : base(context)
    {
    }
}
