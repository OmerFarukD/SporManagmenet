using Microsoft.EntityFrameworkCore;
using SporManagmenet.WebApi.Models.Entities;
using System.Linq.Expressions;

namespace SporManagmenet.WebApi.Repository.Abstracts.EfBases;

public abstract class EfRepositoryBase<TEntity, TId, TContext> : IRepository<TEntity, TId>

    where TEntity : Entity<TId>
    where TContext : DbContext
{
    protected EfRepositoryBase(TContext context)
    {
        Context = context;
    }

    public TContext Context { get;}



    public TEntity Add(TEntity entity)
    {
         Context.Set<TEntity>().Add(entity);
          Context.SaveChanges();
        return entity;
    }

    public bool Any(Expression<Func<TEntity, bool>>? predicate = null, bool enableTracking = true)
    {
        IQueryable<TEntity> query = Query();

        if(predicate is not null)
        {
            query = query.Where(predicate);
        }

        if(enableTracking is false)
        {
            query = query.AsNoTracking();
        }

        return query.Any();
        
    }

    public TEntity? Get(Expression<Func<TEntity, bool>> predicate, bool enableTracking = true, bool include = true)
    {
        IQueryable<TEntity> query = Query();
        if(enableTracking == false)
        {
            query = query.AsNoTracking();
        }

        if(include == false)
        {
            query = query.IgnoreAutoIncludes();
        }

        return query.FirstOrDefault();

    }

    public List<TEntity> GetAll(Expression<Func<TEntity, bool>>? predicate = null, bool enableTracking = true, bool include = true)
    {
        IQueryable<TEntity> query = Query();
        if(predicate is not null)
        {
            query = query.Where(predicate);
        }

        if(enableTracking is false)
        {
           query= query.AsNoTracking();
        }

        if(include is false)
        {
            query = query.IgnoreAutoIncludes();
        }

        return query.ToList();

    }

    public IQueryable<TEntity> Query()
    {
        return Context.Set<TEntity>();
    }

    public TEntity Remove(TEntity entity)
    {
        Context.Set<TEntity>().Remove(entity);
        Context.SaveChanges();

        return entity;
    }

    public TEntity Update(TEntity entity)
    {
        Context.Set<TEntity>().Update(entity);
        Context.SaveChanges();

        return entity;
    }
}
