using Library;
using Microsoft.EntityFrameworkCore;

namespace Lor_Henzo_Taveras_P2_Ap1.Api.DAL
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Accesorios> Accesorios { get; set; }
        public DbSet<Vehiculo> Vehiculo { get; set;}
        public DbSet<VehiculosDetalle> VehiculoDetalle { get; set; }
    }
}
