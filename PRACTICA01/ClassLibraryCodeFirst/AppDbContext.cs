using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCodeFirst
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("connBD")
        {

        }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Venta> Venta { get; set; }
        public DbSet<DetalleVenta> DetalleVenta { get; set; }

    }
}
