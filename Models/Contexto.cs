    using Microsoft.EntityFrameworkCore;
    
    namespace CRUDAPI.Models
    {
       public class Contexto : DbContext{
        

         public DbSet<Pessoa> Pessoas {get; set;} = null;
        
          public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes) {
               
          } 

         protected override void OnModelCreating(ModelBuilder builder)
         {
           base.OnModelCreating(builder);
         }

        }
    }
