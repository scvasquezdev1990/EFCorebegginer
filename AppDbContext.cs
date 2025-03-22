using Microsoft.EntityFrameworkCore;

namespace EFCoreExample
{
  public class AppDbContext : DbContext
  {
    public DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=EFCoreExampleDB;Trusted_Connection=True;Encrypt=False;");
    }
  }
}