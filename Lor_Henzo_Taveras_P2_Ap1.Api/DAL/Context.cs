using Library;
using Microsoft.EntityFrameworkCore;

namespace Lor_Henzo_Taveras_P2_Ap1.Api.DAL
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        DbSet<Accesorios> accesorios { get; set; }
        DbSet<Vehiculo> vehiculo { get; set;}
        DbSet<VehiculosDetalle> vehiculoDetalle { get; set; }
    }
}
