using BaseAPI.Application.DTOs;
using BaseAPI.Domain.Entities;

namespace BaseAPI.Application.Interfaces.Mappers
{
  public interface IMapperProduct
  {
    Product MapperDtoToEntity(ProductDto ProductDto);
    IEnumerable<ProductDto> MapperListProductsDto(IEnumerable<Product> Products);
    ProductDto MapperEntityToDto(Product Product);
  }
}