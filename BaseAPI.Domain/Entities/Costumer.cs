namespace BaseAPI.Domain.Entities
{
  public class Costumer: Base
  {
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public bool isActive { get; set; }
  }
}
