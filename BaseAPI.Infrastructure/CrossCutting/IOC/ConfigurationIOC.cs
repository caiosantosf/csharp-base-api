using Autofac;
using BaseAPI.Application;
using BaseAPI.Application.Interfaces;
using BaseAPI.Application.Interfaces.Mappers;
using BaseAPI.Application.Mapper;
using BaseAPI.Application.Mappers;
using BaseAPI.Domain.Core.Interfaces.Repositories;
using BaseAPI.Domain.Core.Interfaces.Services;
using BaseAPI.Domain.Services;
using BaseAPI.Infrastructure.Data.Repositories;

namespace BaseAPI.Infrastructure.CrossCutting.IOC
{
  public class ConfigurationIOC
  {
    public static void Load(ContainerBuilder builder)
    {
      #region IOC
      builder.RegisterType<ApplicationServiceCostumer>().As<IApplicationServiceCostumer>();
      builder.RegisterType<ApplicationServiceProduct>().As<IApplicationServiceProduct>();

      builder.RegisterType<ServiceCostumer>().As<IServiceCostumer>();
      builder.RegisterType<ServiceProduct>().As<IServiceProduct>();

      builder.RegisterType<RepositoryCostumer>().As<IRepositoryCostumer>();
      builder.RegisterType<RepositoryProduct>().As<IRepositoryProduct>();

      builder.RegisterType<MapperCostumer>().As<IMapperCostumer>();
      builder.RegisterType<MapperProduct>().As<IMapperProduct>();
      #endregion
    }
  }
}