using Microsoft.EntityFrameworkCore;
using WebApplicationAPP.Models;

namespace WebApplicationAPP.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Clientes> Cliente_JafethPoveda { get; set; }
        //public DbSet<WebApplicationAPP.Models.Producto> Productos { get; set; }

        public DbSet<Producto> Producto_JafethPoveda { get; set; }
    }
}
