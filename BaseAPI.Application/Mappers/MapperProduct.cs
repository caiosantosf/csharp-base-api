using BaseAPI.Application.DTOs;
using BaseAPI.Application.Interfaces.Mappers;
using BaseAPI.Domain.Entities;

namespace BaseAPI.Application.Mapper
{
  public class MapperProduct : IMapperProduct
  {
    public Product MapperDtoToEntity(ProductDto productDto)
    {
      return new Product()
      {
        Id = productDto.Id,
        Name = productDto.Name,
        Price = productDto.Price
      };
    }

    public ProductDto MapperEntityToDto(Product product)
    {
      return new ProductDto()
      {
        Id = product.Id,
        Name = product.Name,
        Price = product.Price
      };
    }

    public IEnumerable<ProductDto> MapperListProductsDto(IEnumerable<Product> products)
    {
      return products.Select(c => new ProductDto()
      {
        Id = c.Id,
        Name = c.Name,
        Price = c.Price
      });
    }
  }
}