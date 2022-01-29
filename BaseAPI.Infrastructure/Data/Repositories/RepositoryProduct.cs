using BaseAPI.Domain.Core.Interfaces.Repositories;
using BaseAPI.Domain.Entities;

namespace BaseAPI.Infrastructure.Data.Repositories
{
  public class RepositoryProduct : RepositoryBase<Product>, IRepositoryProduct
  {
    private readonly SqlServerContext context;

    public RepositoryProduct(SqlServerContext sqlServerContext) : base(sqlServerContext)
    {
      context = sqlServerContext;
    }
  }
}