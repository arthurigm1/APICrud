using APICrud.Estudantes;
using Microsoft.EntityFrameworkCore;

namespace APICrud.Data;

public class AppDbContext : DbContext
{
     private DbSet<Estudante> Estudantes{ get; set; }

     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
     {
          optionsBuilder.UseSqlite("Data Source=app.db");
          base.OnConfiguring(optionsBuilder);
     }
}