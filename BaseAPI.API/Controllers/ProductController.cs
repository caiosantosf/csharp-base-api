using Microsoft.AspNetCore.Mvc;
using BaseAPI.Application.DTOs;
using BaseAPI.Application.Interfaces;

namespace BaseAPI.API.Controllers
{
  [Route("[controller]")]
  [ApiController]
  public class ProductsController : ControllerBase
  {
    private readonly IApplicationServiceProduct applicationServiceProduct;

    public ProductsController(IApplicationServiceProduct applicationServiceProduct)
    {
      this.applicationServiceProduct = applicationServiceProduct;
    }

    // GET api/values
    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
      return Ok(applicationServiceProduct.GetAll());
    }

    // GET api/values/5\
    [HttpGet("{id}")]
    public ActionResult<string> Get(int id)
    {
      return Ok(applicationServiceProduct.GetById(id));
    }

    // POST api/values
    [HttpPost]
    public ActionResult Post([FromBody] ProductDto ProductDTO)
    {
      try
      {
        if (ProductDTO == null)
          return NotFound();


        applicationServiceProduct.Add(ProductDTO);
        return Ok("O Product foi cadastrado com sucesso");
      }
      catch (Exception)
      {
        throw;
      }
    }

    // PUT api/values/5
    [HttpPut]
    public ActionResult Put([FromBody] ProductDto ProductDTO)
    {

      try
      {
        if (ProductDTO == null)
          return NotFound();

        applicationServiceProduct.Update(ProductDTO);
        return Ok("O Product foi atualizado com sucesso!");

      }
      catch (Exception)
      {
        throw;
      }
    }

    // DELETE api/values/5
    [HttpDelete()]
    public ActionResult Delete([FromBody] ProductDto ProductDTO)
    {
      try
      {
        if (ProductDTO == null)
          return NotFound();

        applicationServiceProduct.Remove(ProductDTO);
        return Ok("O Product foi removido com sucesso!");

      }
      catch (Exception)
      {
        throw;
      }
    }
  }
}