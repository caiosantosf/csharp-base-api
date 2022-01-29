using BaseAPI.Application.DTOs;
using BaseAPI.Application.Interfaces;
using BaseAPI.Application.Interfaces.Mappers;
using BaseAPI.Domain.Core.Interfaces.Services;

namespace BaseAPI.Application
{
  public class ApplicationServiceCostumer : IApplicationServiceCostumer
  {
    private readonly IServiceCostumer serviceCostumer;
    private readonly IMapperCostumer mapperCostumer;

    public ApplicationServiceCostumer(IServiceCostumer serviceCostumer, IMapperCostumer mapperCostumer)
    {
      this.serviceCostumer = serviceCostumer;
      this.mapperCostumer = mapperCostumer;
    }

    public void Add(CostumerDto costumerDto)
    {
      var costumer = mapperCostumer.MapperDtoToEntity(costumerDto);
      serviceCostumer.Add(costumer);
    }

    public IEnumerable<CostumerDto> GetAll()
    {
      var costumers = serviceCostumer.GetAll();
      return mapperCostumer.MapperListCostumersDto(costumers);
    }

    public CostumerDto GetById(int id)
    {
      var costumer = serviceCostumer.GetById(id);
      return mapperCostumer.MapperEntityToDto(costumer);
    }

    public void Remove(CostumerDto costumerDto)
    {
      var costumer = mapperCostumer.MapperDtoToEntity(costumerDto);
      serviceCostumer.Remove(costumer);
    }

    public void Update(CostumerDto costumerDto)
    {
      var costumer = mapperCostumer.MapperDtoToEntity(costumerDto);
      serviceCostumer.Update(costumer);
    }
  }
}