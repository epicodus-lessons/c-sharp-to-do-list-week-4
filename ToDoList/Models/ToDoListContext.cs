using Microsoft.EntityFrameworkCore;

namespace ToDoList.Models
{
  public class ToDoListContext : DbContext
  {
    public DbSet<Category> Categories { get; set; }
    public DbSet<Item> Items { get; set; }
    
    public ToDoListContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}