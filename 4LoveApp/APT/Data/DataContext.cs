using APT.Entities;
using Microsoft.EntityFrameworkCore;

namespace APT.Data
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions options) : base(options)
    {
    }


public DbSet<AUser> Users { get; set; }

  }
}