using BaseAPI.Application.DTOs;
using BaseAPI.Application.Interfaces.Mappers;
using BaseAPI.Domain.Entities;

namespace BaseAPI.Application.Mappers
{
  public class MapperCostumer : IMapperCostumer
  {
    public Costumer MapperDtoToEntity(CostumerDto costumerDto)
    {
      return new Costumer()
      {
        Id = costumerDto.Id,
        Name = costumerDto.Name,
        Email = costumerDto.Email,
        LastName = costumerDto.LastName
      };
    }

    public CostumerDto MapperEntityToDto(Costumer costumer)
    {
      return new CostumerDto()
      {
        Id = costumer.Id,
        Name = costumer.Name,
        Email = costumer.Email,
        LastName = costumer.LastName
      };
    }

    public IEnumerable<CostumerDto> MapperListCostumersDto(IEnumerable<Costumer> costumers)
    {
      return costumers.Select(c => new CostumerDto()
      {
        Id = c.Id,
        Name = c.Name,
        LastName = c.LastName,
        Email = c.Email,
      });
    }
  }
}