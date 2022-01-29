using BaseAPI.Domain.Core.Interfaces.Repositories;
using BaseAPI.Domain.Entities;

namespace BaseAPI.Infrastructure.Data.Repositories
{
  public class RepositoryCostumer : RepositoryBase<Costumer>, IRepositoryCostumer
  {
    private readonly SqlServerContext context;

    public RepositoryCostumer(SqlServerContext sqlServerContext) : base(sqlServerContext)
    {
      context = sqlServerContext;
    }
  }
}