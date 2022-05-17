using System;
using System.ComponentModel.DataAnnotations;

namespace Animal.Models
{
  public class AnimalType
  {
    [Key]
    public int TypeId { get; set; }
    public string Type { get; set; }
  }
}