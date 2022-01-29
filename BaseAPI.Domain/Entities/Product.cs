namespace BaseAPI.Domain.Entities
{
  public class Product : Base
  {
    public string Name { get; set; }
    public decimal Price { get; set; }
    public bool isAvailable { get; set; }
  }
}
