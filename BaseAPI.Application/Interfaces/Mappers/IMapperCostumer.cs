using BaseAPI.Application.DTOs;
using BaseAPI.Domain.Entities;

namespace BaseAPI.Application.Interfaces.Mappers
{
  public interface IMapperCostumer
  {
    Costumer MapperDtoToEntity(CostumerDto costumerDto);
    IEnumerable<CostumerDto> MapperListCostumersDto(IEnumerable<Costumer> costumers);
    CostumerDto MapperEntityToDto(Costumer costumer);
  }
}