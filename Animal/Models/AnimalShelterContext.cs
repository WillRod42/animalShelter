using Microsoft.EntityFrameworkCore;

namespace Animal.Models
{
  public class AnimalShelterContext : DbContext
  {
    public DbSet<AnimalObject> Animals { get; set; }

    public DbSet<AnimalType> AnimalTypes { get; set; }

    public AnimalShelterContext(DbContextOptions options) : base(options) { }
  }
}