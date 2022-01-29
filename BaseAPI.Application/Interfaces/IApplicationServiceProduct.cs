using BaseAPI.Application.DTOs;

namespace BaseAPI.Application.Interfaces
{
  public interface IApplicationServiceProduct
  {
    void Add(ProductDto ProductDto);
    void Update(ProductDto ProductDto);
    void Remove(ProductDto ProductDto);
    IEnumerable<ProductDto> GetAll();
    ProductDto GetById(int id);
  }
}