using BaseAPI.Domain.Core.Interfaces.Repositories;
using BaseAPI.Domain.Core.Interfaces.Services;
using BaseAPI.Domain.Entities;

namespace BaseAPI.Domain.Services
{
  public class ServiceCostumer : ServiceBase<Costumer>, IServiceCostumer
  { 
    private readonly IRepositoryCostumer repository;

    public ServiceCostumer(IRepositoryCostumer repositoryCostumer) : base(repositoryCostumer)
    {
      repository = repositoryCostumer;
    }
  }
}