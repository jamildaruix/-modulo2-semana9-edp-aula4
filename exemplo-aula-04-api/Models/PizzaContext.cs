using Microsoft.EntityFrameworkCore;

namespace exemplo_aula_04_api.Models
{
    public class PizzaContext : DbContext
    {
        public PizzaContext(DbContextOptions<PizzaContext> options)  : base(options)
        {

        }

        public DbSet<PizzaEntity> PizzaEntities { get; set; }
        public DbSet<PizzaSaborEntity> PizzaSaborEntities { get; set; }
    }
}
