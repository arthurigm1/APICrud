using APICrud.Estudantes;
using Microsoft.EntityFrameworkCore;

namespace APICrud.Data;

public class AppDbContext : DbContext
{
     public DbSet<Estudante> Estudantes{ get; set; }

     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
     {
          optionsBuilder.UseSqlite("Data Source=Banco.sqlite");
          base.OnConfiguring(optionsBuilder);
     }
}