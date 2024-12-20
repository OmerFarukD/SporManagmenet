using SporManagmenet.WebApi.Models.Entities;
using System.Linq.Expressions;

namespace SporManagmenet.WebApi.Repository.Abstracts.EfBases;

public interface IRepository<TEntity, TId> where TEntity : Entity<TId>
{
    TEntity Add(TEntity entity);
    TEntity Update(TEntity entity);
    TEntity Remove(TEntity entity);

    List<TEntity> GetAll(Expression<Func<TEntity, bool>>? predicate = null, bool enableTracking = true, bool include = true);

    TEntity? Get(Expression<Func<TEntity, bool>> predicate, bool enableTracking = true, bool include = true);

    bool Any(Expression<Func<TEntity, bool>>? predicate = null, bool enableTracking = true);

    IQueryable<TEntity> Query();

}
