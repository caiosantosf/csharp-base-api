using BaseAPI.Domain.Core.Interfaces.Repositories;
using BaseAPI.Domain.Core.Interfaces.Services;
using BaseAPI.Domain.Entities;

namespace BaseAPI.Domain.Services
{
  public class ServiceProduct : ServiceBase<Product>, IServiceProduct
  {
    private readonly IRepositoryProduct repository;

    public ServiceProduct(IRepositoryProduct repositoryProduct) : base(repositoryProduct)
    {
      repository = repositoryProduct;
    }
  }
}