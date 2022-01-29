using Microsoft.EntityFrameworkCore;
using BaseAPI.Domain.Core.Interfaces.Repositories;

namespace BaseAPI.Infrastructure.Data.Repositories
{
  public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class 
  {
    private readonly SqlServerContext context;

    public RepositoryBase(SqlServerContext sqlServerContext)
    {
      context = sqlServerContext;
    }

    public void Add(TEntity obj)
    {
      try
      {
        context.Set<TEntity>().Add(obj);
        context.SaveChanges();
      }
      catch (Exception)
      {
        throw;
      }
    }

    public IEnumerable<TEntity> GetAll()
    {
      return context.Set<TEntity>().ToList();
    }

    public TEntity GetById(int id)
    {
      return context.Set<TEntity>().Find(id);
    }

    public void Remove(TEntity obj)
    {
      try
      {
        context.Set<TEntity>().Remove(obj);
        context.SaveChanges();
      }
      catch (Exception)
      {

        throw;
      }
    }

    public void Update(TEntity obj)
    {
      try
      {
        context.Entry(obj).State = EntityState.Modified;
        context.SaveChanges();
      }
      catch (Exception)
      {

        throw;
      }
    }
  }
}
