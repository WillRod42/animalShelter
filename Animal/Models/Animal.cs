using System;

namespace Animal.Models
{
  public class AnimalObject
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsMale { get; set; }
    public DateTime DateOfArival { get; set; }
    public string Breed { get; set; }
    public int TypeId { get; set; }
  }
}