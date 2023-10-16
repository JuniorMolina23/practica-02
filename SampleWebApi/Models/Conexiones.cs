using Microsoft.EntityFrameworkCore;
namespace SampleWebApi.Models;
public class Conexiones : DbContext {
    public Conexiones(DbContextOptions<Conexiones> options)
        : base(options){
    }

    public DbSet<Temperatura> Temperatura { get; set; } = null!;
     
}