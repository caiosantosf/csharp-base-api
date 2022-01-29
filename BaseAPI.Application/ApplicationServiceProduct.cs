using BaseAPI.Application.DTOs;
using BaseAPI.Application.Interfaces;
using BaseAPI.Application.Interfaces.Mappers;
using BaseAPI.Domain.Core.Interfaces.Services;

namespace BaseAPI.Application
{
  public class ApplicationServiceProduct : IApplicationServiceProduct
  {
    private readonly IServiceProduct serviceProduct;
    private readonly IMapperProduct mapperProduct;

    public ApplicationServiceProduct(IServiceProduct serviceProduct, IMapperProduct mapperProduct)
    {
      this.serviceProduct = serviceProduct;
      this.mapperProduct = mapperProduct;
    }

    public void Add(ProductDto productDto)
    {
      var product = mapperProduct.MapperDtoToEntity(productDto);
      serviceProduct.Add(product);
    }

    public IEnumerable<ProductDto> GetAll()
    {
      var products = serviceProduct.GetAll();
      return mapperProduct.MapperListProductsDto(products);
    }

    public ProductDto GetById(int id)
    {
      var product = serviceProduct.GetById(id);
      return mapperProduct.MapperEntityToDto(product);
    }

    public void Remove(ProductDto productDto)
    {
      var product = mapperProduct.MapperDtoToEntity(productDto);
      serviceProduct.Remove(product);
    }

    public void Update(ProductDto productDto)
    {
      var product = mapperProduct.MapperDtoToEntity(productDto);
      serviceProduct.Update(product);
    }
  }
}