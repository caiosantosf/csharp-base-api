using Microsoft.AspNetCore.Mvc;
using BaseAPI.Application.DTOs;
using BaseAPI.Application.Interfaces;

namespace BaseAPI.API.Controllers
{
  [Route("[controller]")]
  [ApiController]
  public class CostumersController : ControllerBase
  {

    private readonly IApplicationServiceCostumer applicationServiceCostumer;


    public CostumersController(IApplicationServiceCostumer applicationServiceCostumer)
    {
      this.applicationServiceCostumer = applicationServiceCostumer;
    }

    // GET api/values
    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
      return Ok(applicationServiceCostumer.GetAll());
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public ActionResult<string> Get(int id)
    {
      return Ok(applicationServiceCostumer.GetById(id));
    }

    // POST api/values
    [HttpPost]
    public ActionResult Post([FromBody] CostumerDto CostumerDTO)
    {
      try
      {
        if (CostumerDTO == null)
          return NotFound();

        applicationServiceCostumer.Add(CostumerDTO);
        return Ok("Costumer Cadastrado com sucesso!");
      }
      catch (Exception)
      {
        throw;
      }
    }

    // PUT api/values/5
    [HttpPut]
    public ActionResult Put([FromBody] CostumerDto CostumerDTO)
    {
      try
      {
        if (CostumerDTO == null)
          return NotFound();

        applicationServiceCostumer.Update(CostumerDTO);
        return Ok("Costumer Atualizado com sucesso!");
      }
      catch (Exception)
      {
        throw;
      }
    }

    // DELETE api/values/5
    [HttpDelete()]
    public ActionResult Delete([FromBody] CostumerDto CostumerDTO)
    {
      try
      {
        if (CostumerDTO == null)
          return NotFound();

        applicationServiceCostumer.Remove(CostumerDTO);
        return Ok("Costumer Removido com sucesso!");
      }
      catch (Exception)
      {
        throw;
      }
    }
  }
}