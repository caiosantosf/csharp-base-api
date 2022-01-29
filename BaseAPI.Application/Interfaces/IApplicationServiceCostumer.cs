using BaseAPI.Application.DTOs;

namespace BaseAPI.Application.Interfaces
{
  public interface IApplicationServiceCostumer
  {
    void Add(CostumerDto costumerDto);
    void Update(CostumerDto costumerDto);
    void Remove(CostumerDto costumerDto);
    IEnumerable<CostumerDto> GetAll();
    CostumerDto GetById(int id);
  }
}